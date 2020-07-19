using System.Collections.Generic;
namespace CorpDataBank.Models
{
    public static class Repository
    {
        private static List<AdminResponse> responses = new List<AdminResponse>();
        public static IEnumerable<AdminResponse> Responses => responses;
        public static void AddResponse(AdminResponse response)
        {
            responses.Add(response);
        }
    }
}