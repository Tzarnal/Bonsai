﻿namespace BonsaiGenerators.Content
{
    public class XKCDCalendarfact : RandomGenerator
    {
        private static readonly RandomTable moment = new RandomTable
        {
            "the Fall Equinox",
            "the Spring Equinox",
            "the winter Solstice",
            "the summer Solstice",
            "the summer Olympics",
            "the winter Olympics",
            "daylight saving time",
            "daylight savings time",
            "leap day",
            "leap year",
            "the harvest moon",
            "the super moon",
            "the blood moon",
            "Toyota truck month",
            "shark week"
        };

        private static readonly RandomTable error = new RandomTable
        {
            "happens earlier every year",
            "happens later every year",
            "happens at the wrong time every year",
            "drifts out of sync with the sun",
            "drifts out of sync with the moon",
            "drifts out of sync with the zodiac",
            "drifts out of sync with the Gregorian calendar",
            "drifts out of sync with the Mayan calendar",
            "drifts out of sync with the Lunar calendar",
            "drifts out of sync with the iPhone calendar",
            "drifts out of sync with the atomic clock in Colorado",
            "might not happen this year",
            "might happen twice this year"
        };

        private static readonly RandomTable reason = new RandomTable
        {
            "time zone legislation in Indiana",
            "time zone legislation in Arizona",
            "time zone legislation in Russia",
            "a decree by the pope in the 1500s",
            "magnetic field reversal",
            "an arbitrary decision by Benjamin Franklin",
            "an arbitrary decision by Isaac Newton",
            "an arbitrary decision by FDR"
        };

        private static readonly RandomTable factiod = new RandomTable
        {
            "it causes a predictable increase in car accidents",
            "that's why we have leap seconds",
            "scientists are really worried",
            "it was even more extreme during the Bronze Age",
            "it was even more extreme during the Ice Age",
            "it was even more extreme during the Cretaceous",
            "it was even more extreme during the 1990s",
            "there's a proposal to fix it, but it will never happen",
            "there's a proposal to fix it, but it actually makes things worse",
            "there's a proposal to fix it, but it is stalled in congress",
            "there's a proposal to fix it, but it might be unconstitutional",
            "its getting worse and no one knows why"
        };

        private static readonly RandomTableWeighted consequence = new RandomTableWeighted
        {
            {"", 5 },
            {"While it may seem like trivia it causes huge headaches for software developers.", 1 },
            {"While it may seem like trivia it is taken advantage of by high-speed traders.", 1 },
            {"While it may seem like trivia it triggered the 2003 Northeast Blackout.", 1 },
            {"While it may seem like trivia it has to be corrected for by GPS satellites.", 1 },
            {"While it may seem like trivia it is now recognized as a major cause of World War I.", 1 }
        };

        public override string ToString()
        {
            return $"Did you know that {moment} {error} because of {reason}? Apparantly {factiod}. {consequence}";
        }
    }
}