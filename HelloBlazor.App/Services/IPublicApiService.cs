using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public interface IPublicApiService{
    Task<IEnumerable<PublicApiEntry>> GetPublicApiEntries();
}