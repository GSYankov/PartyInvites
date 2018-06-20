using System.Collections.Generic;
using System.Linq;

namespace PartyInvites.Models
{
    public static class Repository
    {
        private static List<GuestResponse> responses = new List<GuestResponse>();

        public static IEnumerable<GuestResponse> Responses
        {
            get
            {
                return responses;
            }
        }

        public static void AddResponse(GuestResponse response)
        {
            responses.Add(response);

        }

        public static void AddG()
        {
            if (responses.Count==0)
            {
                GuestResponse g = new GuestResponse { Name = "Georgi Yankov",
                                                      Email = "Georgi.S.Yankov@gmail.com",
                                                      Phone = "+359 887 101040",
                                                      WillAttend = true };
                responses.Add(g);
            }
        }
    }
}