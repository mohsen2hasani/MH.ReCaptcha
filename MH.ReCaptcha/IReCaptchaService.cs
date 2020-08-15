using System.Threading.Tasks;

namespace MH.ReCaptcha
{
    public interface IReCaptchaService
    {
        Task<bool> Verify(string reCaptchaResponse);
    }
}