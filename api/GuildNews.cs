using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace lol
{
    //{"lastModified":1392569795000,"name":"Lords of the Locker Room","realm":"Ragnaros","battlegroup":"Rampage / Saccage","level":25,"side":1,"achievementPoints":485
    //emblem
    //news
    [DataContract]
    public class GuildNews
    {
        [DataMember(Name = "lastModified")]
        public long lastModified { get; set; }
        [DataMember(Name = "name")]
        public string name { get; set; }
        [DataMember]
        public string realm { get; set; }
        [DataMember]
        public string battlegroup { get; set; }
        [DataMember]
        public int level { get; set; }
        [DataMember]
        public int side { get; set; }
        [DataMember]
        public int achievementPoints { get; set; }
        [DataMember]
        public Emblem emblem { get; set; }
        [DataMember]
        public List<News> news { get; set; }
    }

    //{"icon":93,"iconColor":"ff00671f","border":0,"borderColor":"ff00671f","backgroundColor":"ff860f9a"}
    [DataContract]
    public class Emblem
    {
        [DataMember]
        public int icon { get; set; }
        [DataMember]
        public string iconColor { get; set; }
        [DataMember]
        public int border { get; set; }
        [DataMember]
        public string backgroundColor { get; set; }
    }


    //{"type":"itemPurchase","character":"Bloodsong","timestamp":1392575880000,"itemId":99046}

    //{"type":"playerAchievement","character":"Frakira","timestamp":1392575100000,
    //"achievement":{"id":6,"title":"Level 10","points":10,"description":"Reach level 10.","rewardItems":[],"icon":"achievement_level_10","criteria":[],"accountWide":false,"factionId":2}}

    //{"type":"itemLoot","character":"Fridluffs","timestamp":1392573120000,"itemId":86843}

    //{"type":"guildAchievement","character":"Qoad","timestamp":1392162660000,
    //"achievement":{"id":5164,"title":"Classy Undead","points":10,"description":"Reach level 85 on each of the Undead classes listed below.",
    //"rewardItems":[],"icon":"achievement_character_undead_male",
    //"criteria":[{"id":14627,"description":"Mage","orderIndex":0,"max":85},{"id":14628,"description":"Priest","orderIndex":1,"max":85},
    //{"id":14629,"description":"Rogue","orderIndex":2,"max":85},{"id":14630,"description":"Warlock","orderIndex":3,"max":85},
    //{"id":14631,"description":"Death Knight","orderIndex":4,"max":85},{"id":14632,"description":"Warrior","orderIndex":5,"max":85},
    //{"id":14647,"description":"Hunter","orderIndex":6,"max":85},{"id":22116,"description":"Monk","orderIndex":7,"max":85}],"accountWide":false,"factionId":1}}
    [DataContract]
    public class News
    {
        [DataMember]
        public string type { get; set; }
        [DataMember]
        public string character { get; set; }
        [DataMember]
        public long timestamp { get; set; }
        [DataMember]
        public int itemId { get; set; }
        [DataMember]
        public Achievement achievement { get; set; }
    }

    [DataContract]
    public class Achievement
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string title { get; set; }
        [DataMember]
        public int points { get; set; }
        [DataMember]
        public string description { get; set; }
        [DataMember]
        public List<Reward> rewardItems { get; set; }
        [DataMember]
        public string icon { get; set; }
        [DataMember]
        public List<Criteria> criteria { get; set; }
        [DataMember]
        public Boolean accountWide { get; set; }
        [DataMember]
        public int factionId { get; set; }
    }

    [DataContract]
    public class Criteria
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string description { get; set; }
        [DataMember]
        public int orderIndex { get; set; }
        [DataMember]
        public int max { get; set; }
    }

    //"rewardItems":[{"id":41426,"name":"Magically Wrapped Gift","icon":"inv_misc_gift_02","quality":1,"itemLevel":1,"tooltipParams":{},"stats":[],"armor":0}]
    [DataContract]
    public class Reward
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string icon { get; set; }
        [DataMember]
        public int quality { get; set; }
        //[DataMember]
        //public List<TooltipParams> tooltipParams { get; set; }
        [DataMember]
        public List<Stat> stats { get; set; }
        [DataMember]
        public int armor { get; set; }
    }

    //"stats":[{"stat":32,"amount":178},{"stat":5,"amount":267},{"stat":36,"amount":178},{"stat":7,"amount":401}]
    [DataContract]
    public class Stat
    {
        [DataMember]
        public int stat { get; set; }
        [DataMember]
        public int amount { get; set; }
    }
}