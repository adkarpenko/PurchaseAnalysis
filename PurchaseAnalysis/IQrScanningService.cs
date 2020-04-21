using System;
using System.Threading.Tasks;
namespace PurchaseAnalysis
{
    public interface IQrScanningService
    {
        Task<string> ScanAsync();
    }
}
