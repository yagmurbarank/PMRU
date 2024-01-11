using PMRU.Application.Bases;

namespace PMRU.Application.Features.Auth.Exceptions
{
    public class EmailAdressShouldBeValidException : BaseException
    {
        public EmailAdressShouldBeValidException() : base("Böyle bir email adresi bulunmamaktadır.") { }
    }
}
