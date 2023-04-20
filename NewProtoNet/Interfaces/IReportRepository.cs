using Domain.Entities;
using RestServer.DTOs;

namespace RestServer.Interfaces
{
    public interface IReportRepository
    {
        Task<List<Report>> GetReports();
        Task<List<Report>> GetByPage(int page);

        Task<Report> GetReport(int id);
        Task<Report> PostReport(ReportDTO Report);
        Task<Report> UpdateReport(int id, ReportDTO Report);
        Task<Report> DeleteReport(int id);
    }
}
