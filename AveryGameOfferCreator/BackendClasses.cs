using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AveryGameOfferCreator
{
    internal class DefaultResponse
    {
        public int code { get; set; }
        public string message { get; set; }
    }

    internal class AdminCredentials
    {
        public string username { get; set; }
        public string password { get; set; }
    }

    internal class AuthenticateAdminResponse : DefaultResponse
    {
        public string key { get; set; }
        public string userId { get; set; }
    }

    internal class Reward
    {
        public string rewardName { get; set; }
        public bool statReward { get; set; }
        public string statName { get; set; }
        public string statValue { get; set; }
        public bool microtransactionalReward { get; set; }
        public int microtransactionalAmount { get; set; }
    }

    internal class Offer
    {
        public string offerName { get; set; }
        public string redemptionMessage { get; set; }
        public bool promotionalOffer { get; set; }
        public string promotionalCode { get; set; }
        public bool microtransactionalRequirement { get; set; }
        public int cost { get; set; }
        public List<Reward> rewards { get; set; }
    }

    internal class OfferRequest : AdminCredentials
    {
        public Offer offer { get; set; }
    }
        
}
