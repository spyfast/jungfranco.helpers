using System.Text.RegularExpressions;

namespace JungFranco.Helpers.Misc
{
    public struct TargetData
    {
        public enum TypeOfTarget
        {
            Unknown,
            NotFound,
            PersonalMessage,
            Chat,
            Wall,
            Photo,
            Video,
            Topic
        }
        public readonly TypeOfTarget Type;
        public long? Id1, Id2;

        public TargetData(TypeOfTarget type, string id1, string id2)
        {
            Type = type;
            Id1 = long.Parse(id1);
            Id2 = long.Parse(id2);
        }

        public TargetData(TypeOfTarget type)
        {
            Type = type;
            Id1 = Id2 = null;
        }
    }
    public static class LinkParser
    {
        public static TargetData Parse(string link)
        {
            Match patternChat = new Regex("im\\?sel=c([0-9]+)").Match(link);
            Match patternPm = new Regex("im\\?sel=([0-9]+)").Match(link);
            Match patternWall = new Regex("wall(-?[0-9]+)_([0-9]+)").Match(link);
            Match patternPhoto = new Regex("photo(-?[0-9]+)_([0-9]+)").Match(link);
            Match patternVideo = new Regex("video(-?[0-9]+)_([0-9]+)").Match(link);
            Match patternTopic = new Regex("topic([0-9]+)_([0-9]+)").Match(link);

            if (patternChat.Success)
            {
                return new TargetData(TargetData.TypeOfTarget.Chat, patternChat.Groups[1].Value, "0");
            }
            if (patternPm.Success)
            {
                return new TargetData(TargetData.TypeOfTarget.PersonalMessage, patternPm.Groups[1].Value, "0");
            }
            if (patternWall.Success)
            {
                return new TargetData(TargetData.TypeOfTarget.Wall, patternWall.Groups[1].Value, patternWall.Groups[2].Value);
            }
            if (patternPhoto.Success)
            {
                return new TargetData(TargetData.TypeOfTarget.Photo, patternPhoto.Groups[1].Value, patternPhoto.Groups[2].Value);
            }
            if (patternVideo.Success)
            {
                return new TargetData(TargetData.TypeOfTarget.Video, patternVideo.Groups[1].Value, patternVideo.Groups[2].Value);
            }
            if (patternTopic.Success)
            {
                return new TargetData(TargetData.TypeOfTarget.Topic, patternTopic.Groups[1].Value, patternTopic.Groups[2].Value);
            }

            return new TargetData(TargetData.TypeOfTarget.Unknown);
        }
    }
}
