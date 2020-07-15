using System;
using System.Collections.Generic;
using System.Threading.Tasks;

interface IPublicApiService{
    Task<IEnumerable<PublicApiEntry>> GetPublicApiEntries();
}