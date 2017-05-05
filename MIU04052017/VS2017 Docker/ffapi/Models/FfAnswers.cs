using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ffapi.Models
{
    public class FfAnswers : Dictionary<int, string>
    {

        private void AddValue(string value)
        {
            this.Add(this.Count, value);
        }
        public FfAnswers()
        {
            this.AddValue("Of course there is that Outfit at Farfetch");
            this.AddValue("We don't sell ugly clothe!");
            this.AddValue("Without a doubt");
            this.AddValue("Forget that, Farfetch is a Luxury Boutique!");
            this.AddValue("It Depends, if it's xmas time, we'll be selling like crazy!");
            this.AddValue("I know what music stars, usually dress!");
            this.AddValue("Amazon??!? pffff Those guys are not in the retail biz!");
            this.AddValue("Farfetch has express worldwide delivery and same-day delivery in London, New York, Paris, Los Angeles, Miami, Madrid, Milan, Barcelona and Rome, plus swift and simple returns.");
            this.AddValue("Yes");
            this.AddValue("Yes, Farfetch secured a Series F round of investment of US $110 million.");
            this.AddValue("What?? Nevermind. At Farfetch, we like to think big and think global. Our offices are found in 11 cities, including London, Tokyo and Los Angeles, and we express ship from partners to over 190 countries worldwide.");
            this.AddValue("Ask again later");
            this.AddValue("I would recomend you outfits, but Inspire is under heavy maintenace right now!");
            this.AddValue("This is not Macy's! We only provide the best online shopping experience!");
        }
    }
}
