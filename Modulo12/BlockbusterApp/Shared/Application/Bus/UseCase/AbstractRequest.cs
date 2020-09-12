using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;

namespace BlockbusterApp.src.Shared.Application.Bus.UseCase
{
    public abstract class AbstractRequest : IRequest
    {
        private Dictionary<string,int> page;

        public AbstractRequest(IQueryCollection query)
        {
            this.SetPage(query["page[number]"], query["page[size]"]);
        }

        private void SetPage(StringValues pageNumber, StringValues pageSize)
        {
            this.page = new Dictionary<string, int>();


            if (pageNumber.Count > 0)
            {
                this.page.Add("number", System.Int16.Parse(pageNumber.ToString()));
            } else
            {
                this.page.Add("number", 1);
            }

            if (pageSize.Count > 0)
            {
                this.page.Add("size", System.Int16.Parse(pageSize.ToString()));
            } else
            {
                this.page.Add("size", 10);
            }
        }

        public Dictionary<string, int> Page()
        {
            return this.page;
        }
    }
}
