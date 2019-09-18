using System;

namespace ConnectApp.Models.ActionModel {
    public class ChannelDetailScreenActionModel : BaseActionModel {
        public Action pushToChannelMembers;
        public Action pushToChannelIntroduction;
        public Action fetchMembers;
        public Action leaveChannel;
    }
}