using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_store_with_discounts
{
    public interface IEmailService
    {
        void SendEmail(string to, string subject, string body);
    }
}
