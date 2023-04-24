using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using RestServer.Data;
using RestServer.DTOs;
using RestServer.Interfaces;
using System.Drawing.Printing;

namespace RestServer.Repositories
{
    public class ReportRepository : IReportRepository
    {

        private readonly BaseDbContext dbContext;

        public ReportRepository(BaseDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        async Task<List<Report>> IReportRepository.GetReports()
        {
            return await this.dbContext.Reports!.ToListAsync();
        }

        async Task<Report?> IReportRepository.GetReport(int id)
        {
            Report? Report = await dbContext.Reports!.FirstOrDefaultAsync(m => m.Id == id);
            return (Report != null) ? Report : null;
        }

        async Task<Report> IReportRepository.PostReport(ReportDTO ReportDTO)
        {
            Report Report = new Report()
            {
                Type = ReportDTO.Type,
            };

            await this.dbContext.Reports!.AddAsync(Report);
            await this.dbContext.SaveChangesAsync();

            return Report;
        }

        async Task<Report?> IReportRepository.UpdateReport(int id, ReportDTO Report)
        {
            Report? encontrado = await this.dbContext.Reports!.FindAsync(id);
            if (encontrado == null)
            {
                return encontrado;
            }

            encontrado.Type = Report.Type;
            await this.dbContext.SaveChangesAsync();

            return encontrado;
        }

        async Task<Report?> IReportRepository.DeleteReport(int id)
        {
            Report? encontrado = await dbContext.Reports!.FindAsync(id);
            if (encontrado != null)
            {
                this.dbContext.Remove(encontrado);
                this.dbContext.SaveChanges();
            }
            return encontrado!;
        }

        async Task<List<Report>> IReportRepository.GetByPage(int page)
        {
            const int pageSize = 10;
            List<Report> Reports = await this.dbContext.Reports!.ToListAsync();
            int totalPages = (int)Math.Ceiling((double)Reports.Count / pageSize);
            return (page <= totalPages) ? Reports.Skip((page - 1) * pageSize).Take(pageSize).ToList() : new List<Report>();
        }
    }
}