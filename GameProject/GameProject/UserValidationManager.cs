using GameProject.Abstract;
using GameProject.Entity;
using MersisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserCheckService
    {
        public bool Validate(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync
                (Convert.ToInt64(gamer.IdentityNumber), gamer.FirstName.ToUpper(),
                gamer.LastName.ToUpper(), gamer.BirthOfDate.Year).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
