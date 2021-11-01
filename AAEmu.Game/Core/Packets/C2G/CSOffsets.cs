﻿namespace AAEmu.Game.Core.Packets.C2G
{
    public static class CSOffsets
    {
        // All opcodes here are updated for client 1.2 version 223748 March 18, 2015
        public const ushort X2EnterWorldPacket = 0x00;
        // double _01_&_05_
        public const ushort CSResturnAddrsPacket = 0x056;     // level = 1
        public const ushort CSResturnAddrs_05_Packet = 0x056; // level = 5
        public const ushort CSHGResponsePacket = 0x043;       // level = 1
        public const ushort CSHGResponse_05_Packet = 0x043;   // level = 5
        public const ushort CSAesXorKeyPacket = 0x03e;        // level = 1
        public const ushort CSAesXorKey_05_Packet = 0x03e;    // level = 5

        public const ushort off_399AE130 = 0x133;
        public const ushort off_399AE554 = 0x141;
        public const ushort CSMoveUnitPacket = 0x03C;
        public const ushort CSCofferInteractionPacket = 0x0A4;
        public const ushort CSRemoveCommonFarmsPacket = 0x05E;
        public const ushort CSPlaceCommonFarmPacket = 0x122;
        public const ushort CSRequestCommonFarmListPacket = 0x0FC;
        public const ushort CSChallengeDuelPacket = 0x0C1;
        public const ushort CSStartDuelPacket = 0x088;
        public const ushort CSConvertItemLookPacket = 0x0CD;
        public const ushort off_399AEFF8 = 0x066;
        public const ushort CSSetPingPosPacket = 0x047;
        public const ushort CSICSMoneyRequestPacket = 0x01F;
        public const ushort CSChangeMateNamePacket = 0x114;
        public const ushort CSRankCharacterPacket = 0x0AB;
        public const ushort CSRankSnapshotPacket = 0x0ED;
        public const ushort CSRequestSecondPasswordKeyTablesPacket = 0x051;
        public const ushort CSCreateSecondPasswordPacket = 0x081;
        public const ushort CSChangeSecondPasswordPacket = 0x0CE;
        public const ushort CSClearSecondPasswordPacket = 0x044;
        public const ushort CSCheckSecondPasswordPacket = 0x0AF;
        public const ushort CSReplyImprisonOrTrialPacket = 0x0EF;
        public const ushort CSSkipFinalStatementPacket = 0x0F4;
        public const ushort CSReplyInviteJuryPacket = 0x12A;
        public const ushort CSJurySummonedPacket = 0x04B;
        public const ushort CSJuryEndTestimonyPacket = 0x009;
        public const ushort CSCancelTrialPacket = 0x0F8;
        public const ushort CSJuryVerdictPacket = 0x082;
        public const ushort CSReportCrimePacket = 0x0C6;
        public const ushort CSRequestJuryWaitingNumberPacket = 0x11C;
        public const ushort CSRequestSetBountyMoneyPacket = 0x0D5;
        public const ushort CSUpdateBountyPacket = 0x0F5;
        public const ushort off_399B2E84 = 0x0E1;
        public const ushort CSSendUserMusicPacket = 0x011;
        public const ushort CSSaveUserMusicNotesPacket = 0x0B0;
        public const ushort CSRequestMusicNotesPacket = 0x0B5;
        public const ushort CSPauseUserMusicPacket = 0x0C8;
        public const ushort CSSkillControllerStatePacket = 0x00B;
        public const ushort CSMountMatePacket = 0x045;
        public const ushort CSLeaveWorldPacket = 0x06B;
        public const ushort CSCancelLeaveWorldPacket = 0x07E;
        public const ushort CSIdleStatusPacket = 0x032;
        public const ushort off_399BD034 = 0x12F;
        public const ushort CSCompletedCinemaPacket = 0x09E;
        public const ushort CSCheckDemoModePacket = 0x01A;
        public const ushort CSResetDemoCharPacket = 0x135;
        public const ushort CSConsoleCmdUsedPacket = 0x146;
        public const ushort CSEditorGameModePacket = 0x05D;
        public const ushort CSEditorRemoveGimmickPacket = 0x10B;
        public const ushort CSInteractGimmickPacket = 0x0CA;
        public const ushort CSEditorAddGimmickPacket = 0x001;
        public const ushort CSWorldRayCastingPacket = 0x020;
        public const ushort CSRefreshInCharacterListPacket = 0x019;
        public const ushort CSDeleteCharacterPacket = 0x0AD;
        public const ushort CSCancelCharacterDeletePacket = 0x0E3;
        public const ushort CSSelectCharacterPacket = 0x142;
        public const ushort CSNotifyInGamePacket = 0x02C;
        public const ushort CSNotifyInGameCompletedPacket = 0x00F;
        public const ushort CSChangeTargetPacket = 0x01B;
        public const ushort CSResurrectCharacterPacket = 0x0CF;
        public const ushort CSCriminalLockedPacket = 0x02F;
        public const ushort CSExpressEmotionPacket = 0x0A8;
        public const ushort CSUnhangPacket = 0x042;
        public const ushort CSChangeAppellationPacket = 0x08A;
        public const ushort CSStartedCinemaPacket = 0x07B;
        public const ushort CSHSResponsePacket = 0x0F2;
        public const ushort CSBroadcastVisualOptionPacket = 0x034;
        public const ushort CSRestrictCheckPacket = 0x06A;
        public const ushort CSICSMenuListPacket = 0x08C;
        public const ushort CSICSGoodsListPacket = 0x0E8;
        public const ushort CSICSBuyGoodPacket = 0x04E;
        public const ushort CSPremiumServiceBuyPacket = 0x0B9;
        public const ushort CSPremiumServieceMsgPacket = 0x0C0;
        public const ushort off_399C4484 = 0x008;
        public const ushort off_399C4490 = 0x033;
        public const ushort CSICSBuyAAPointPacket = 0x055;
        public const ushort CSRequestTencentFatigueInfoPacket = 0x104;
        public const ushort CSPremiumServiceListPacket = 0x105;
        public const ushort off_399C44C0 = 0x00F;
        public const ushort off_399C44CC = 0x118;
        public const ushort CSSpawnCharacterPacket = 0x0FA;
        public const ushort CSCreateCharacterPacket = 0x072;
        public const ushort CSEditCharacterPacket = 0x028;
        public const ushort CSTeleportEndedPacket = 0x080;
        public const ushort CSListCharacterPacket = 0x03E;
        public const ushort CSNotifySubZonePacket = 0x0EE;
        public const ushort CSSaveTutorialPacket = 0x029;
        public const ushort CSRequestUIDataPacket = 0x046;
        public const ushort CSSaveUIDataPacket = 0x10E;
        public const ushort CSBeautyshopDataPacket = 0x03F;
        public const ushort CSUpdateDominionTaxRatePacket = 0x13A;
        public const ushort CSUpdateNationalTaxRatePacket = 0x01C;
        public const ushort CSRequestCharBriefPacket = 0x0AA;
        public const ushort CSCreateExpeditionPacket = 0x09B;
        public const ushort CSChangeExpeditionRolePolicyPacket = 0x0DB;
        public const ushort CSChangeExpeditionMemberRolePacket = 0x03D;
        public const ushort CSChangeExpeditionOwnerPacket = 0x11A;
        public const ushort CSRenameExpeditionPacket = 0x0FF;
        public const ushort CSDismissExpeditionPacket = 0x123;
        public const ushort CSInviteToExpeditionPacket = 0x0BA;
        public const ushort CSLeaveExpeditionPacket = 0x0AC;
        public const ushort CSKickFromExpeditionPacket = 0x05A;
        public const ushort CSChangeCVarPacket = 0x10A;
        public const ushort CSFactionImmigrationInvitePacket = 0x0A2;
        public const ushort CSFactionImmigrationInviteReplyPacket = 0x0FE;
        public const ushort CSFactionImmigrateToOriginPacket = 0x0EA;
        public const ushort CSFactionKickToOriginPacket = 0x11D;
        public const ushort CSFactionDeclareHostilePacket = 0x11B;
        public const ushort CSExpeditionInvitationPacket = 0x08D;
        public const ushort CSFamilyInviteMemberPacket = 0x00A;
        public const ushort CSFamilyLeavePacket = 0x01D;
        public const ushort CSFamilyKickPacket = 0x100;
        public const ushort CSFamilyChangeTitlePacket = 0x0C3;
        public const ushort CSFamilyChangeOwnerPacket = 0x0C4;
        public const ushort CSFamilyReplyInvitationPacket = 0x138;
        public const ushort CSAddFriendPacket = 0x115;
        public const ushort CSDeleteFriendPacket = 0x07A;
        public const ushort CSAddBlockedUserPacket = 0x0F3;
        public const ushort CSDeleteBlockedUserPacket = 0x0A1;
        public const ushort CSInviteAreaToTeamPacket = 0x13F;
        public const ushort CSInviteToTeamPacket = 0x0FB;
        public const ushort CSReplyToJoinTeamPacket = 0x0C2;
        public const ushort CSLeaveTeamPacket = 0x125;
        public const ushort CSKickTeamMemberPacket = 0x125;
        public const ushort CSMakeTeamOwnerPacket = 0x096;
        public const ushort CSConvertToRaidTeamPacket = 0x04D;
        public const ushort CSMoveTeamMemberPacket = 0x0E4;
        public const ushort CSDismissTeamPacket = 0x125;
        public const ushort CSSetTeamMemberRolePacket = 0x0D8;
        public const ushort CSSetOverHeadMarkerPacket = 0x10D;
        public const ushort CSAskRiskyTeamActionPacket = 0x125;
        public const ushort CSChangeLootingRulePacket = 0x035;
        public const ushort CSUpdateActionSlotPacket = 0x00D;
        public const ushort CSUsePortalPacket = 0x095;
        public const ushort CSUpgradeExpertLimitPacket = 0x0C7;
        public const ushort CSDowngradeExpertLimitPacket = 0x073;
        public const ushort CSExpandExpertPacket = 0x022;
        public const ushort off_399DF0C0 = 0x041;
        public const ushort CSCreateShipyardPacket = 0x069;
        public const ushort CSCreateHousePacket = 0x069;
        public const ushort off_399DF2EC = 0x0DE;
        public const ushort CSConstructHouseTaxPacket = 0x05C;
        public const ushort CSChangeHouseNamePacket = 0x126;
        public const ushort CSChangeHousePermissionPacket = 0x101;
        public const ushort CSRequestHouseTaxPacket = 0x01E;
        public const ushort CSSellHouseCancelPacket = 0x08E;
        public const ushort CSDecorateHousePacket = 0x0BD;
        public const ushort CSChangeHousePayPacket = 0x0D7;
        public const ushort CSSellHousePacket = 0x103;
        public const ushort CSBuyHousePacket = 0x0B7;
        public const ushort CSRemoveMatePacket = 0x0DA;
        public const ushort CSChangeMateTargetPacket = 0x0A5;
        public const ushort CSChangeMateUserStatePacket = 0x124;
        public const ushort off_399E1114 = 0x091;
        public const ushort off_399E1120 = 0x0E9;
        public const ushort off_399E1174 = 0x0E9;
        public const ushort CSSpawnSlavePacket = 0x0F0;
        public const ushort CSDespawnSlavePacket = 0x07C;
        public const ushort CSDestroySlavePacket = 0x106;
        public const ushort CSBindSlavePacket = 0x132;
        public const ushort CSDiscardSlavePacket = 0x084;
        public const ushort off_399E1274 = 0x018;
        public const ushort off_399E12AC = 0x0B2;
        public const ushort CSBoardingTransferPacket = 0x084;
        public const ushort CSTurretStatePacket = 0x0F6;
        public const ushort CSCreateSkillControllerPacket = 0x013;
        public const ushort CSJoinTrialAudiencePacket = 0x031;
        public const ushort CSLeaveTrialAudiencePacket = 0x0B4;
        public const ushort CSUnMountMatePacket = 0x136;
        public const ushort CSUnbondDoodadPacket = 0x0B4;
        public const ushort CSInstanceLoadedPacket = 0x0EE;
        public const ushort CSApplyToInstantGamePacket = 0x071;
        public const ushort CSCancelInstantGamePacket = 0x09C;
        public const ushort CSJoinInstantGamePacket = 0x117;
        public const ushort CSEnteredInstantGameWorldPacket = 0x050;
        public const ushort CSLeaveInstantGamePacket = 0x0E6;
        public const ushort CSQuestUnkPacket = 0x014;
        public const ushort CSStartQuestContextPacket = 0x11F;
        public const ushort CSCompleteQuestContextPacket = 0x0E0;
        public const ushort CSDropQuestContextPacket = 0x139;
        public const ushort CSQuestTalkMadePacket = 0x02A;
        public const ushort CSQuestStartWithPacket = 0x09D;
        public const ushort CSTryQuestCompleteAsLetItDonePacket = 0x057;
        public const ushort CSRestartMainQuestPacket = 0x13C;
        public const ushort off_399E2950 = 0x0CC;
        public const ushort off_399E2974 = 0x016;
        public const ushort CSLearnSkillPacket = 0x0D9;
        public const ushort CSLearnBuffPacket = 0x099;
        public const ushort CSResetSkillsPacket = 0x069;
        public const ushort CSSwapAbilityPacket = 0x10C;
        public const ushort CSRemoveBuffPacket = 0x0AE;
        public const ushort CSStopCastingPacket = 0x0BE;
        public const ushort CSDeletePortalPacket = 0x077;
        public const ushort CSSetForceAttackPacket = 0x05B;
        public const ushort CSStartSkillPacket = 0x07D;
        public const ushort CSCreateDoodadPacket = 0x0B3;
        public const ushort CSNaviTeleportPacket = 0x0B8;
        public const ushort CSNaviOpenPortalPacket = 0x061;
        public const ushort CSNaviOpenBountyPacket = 0x06F;
        public const ushort CSSetLogicDoodadPacket = 0x00C;
        public const ushort CSCleanupLogicLinkPacket = 0x025;
        public const ushort CSSelectInteractionExPacket = 0x0A0;
        public const ushort CSChangeDoodadDataPacket = 0x078;
        public const ushort CSBuyItemsPacket = 0x134;
        public const ushort CSBuyCoinItemPacket = 0x0DD;
        public const ushort CSChangeDoodadPhasePacket = 0x068;
        public const ushort CSHangPacket = 0x04F;
        public const ushort CSInteractNPCPacket = 0x0A3;
        public const ushort CSInteractNPCEndPacket = 0x0D2;
        public const ushort CSStartInteractionPacket = 0x04C;
        public const ushort CSSpecialtyRatioPacket = 0x006;
        public const ushort CSListSpecialtyGoodsPacket = 0x0DC;
        public const ushort off_399D3538 = 0x023;
        public const ushort CSJoinUserChatChannelPacket = 0x0D1;
        public const ushort CSLeaveChatChannelPacket = 0x0BB;
        public const ushort CSSendChatMessagePacket = 0x021;
        public const ushort CSRollDicePacket = 0x0C9;
        public const ushort CSSendMailPacket = 0x0BC;
        public const ushort CSListMailPacket = 0x12C;
        public const ushort CSListMailContinuePacket = 0x065;
        public const ushort CSReadMailPacket = 0x0F9;
        public const ushort CSTakeAttachmentMoneyPacket = 0x067;
        public const ushort CSTakeAllSelectedAttachmentPacket = 0x083;
        public const ushort CSPayChargeMoneyPacket = 0x129;
        public const ushort CSDeleteMailPacket = 0x0D6;
        public const ushort CSReportSpamPacket = 0x0B6;
        public const ushort CSTakeAllAttachmentItemPacket = 0x093;
        public const ushort CSTakeAttachmentItemPacket = 0x109;
        public const ushort CSActiveWeaponChangedPacket = 0x005;
        public const ushort CSRepairSlaveItemsPacket = 0x127;
        public const ushort CSRepairPetItemsPacket = 0x089;
        public const ushort CSAllowHousingRecoverPacket = 0x0A9;
        public const ushort CSBuyPriestBuffPacket = 0x08F;
        public const ushort CSChangeSlaveNamePacket = 0x0FD;
        public const ushort CSUseTeleportPacket = 0x12B;
        public const ushort CSAuctionPostPacket = 0x08B;
        public const ushort CSAuctionSearchPacket = 0x064;
        public const ushort CSAuctionMyBidListPacket = 0x079;
        public const ushort CSAuctionLowestPricePacket = 0x0BF;
        public const ushort CSCancelAuctionPacket = 0x102;
        public const ushort CSAuctionBidPacket = 0x049;
        public const ushort CSExecuteCraftPacket = 0x131;
        public const ushort CSSetLpManageCharacterPacket = 0x137;
        public const ushort CSChangeItemLookPacket = 0x048;
        public const ushort CSDestroyItemPacket = 0x0A7;
        public const ushort CSSplitBagItemPacket = 0x052;
        public const ushort CSSwapItemsPacket = 0x012;
        public const ushort CSSplitCofferItemPacket = 0x087;
        public const ushort CSSwapCofferItemsPacket = 0x0E5;
        public const ushort CSExpandSlotsPacket = 0x111;
        public const ushort CSDepositMoneyPacket = 0x090;
        public const ushort CSWithdrawMoneyPacket = 0x0D4;
        public const ushort CSItemSecurePacket = 0x112;
        public const ushort CSItemUnsecurePacket = 0x113;
        public const ushort CSEquipmentsSecurePacket = 0x015;
        public const ushort CSEquipmentsUnsecurePacket = 0x059;
        public const ushort CSRepairSingleEquipmentPacket = 0x069;
        public const ushort CSRepairAllEquipmentsPacket = 0x069;
        public const ushort CSChangeAutoUseAAPointPacket = 0x05F;
        public const ushort CSThisTimeUnpackItemPacket = 0x02D;
        public const ushort CSTakeScheduleItemPacket = 0x004;
        public const ushort CSChangeMateEquipmentPacket = 0x02B;
        public const ushort CSChangeSlaveEquipmentPacket = 0x030;
        public const ushort CSItemUccPacket = 0x128;
        public const ushort CSLootOpenBagPacket = 0x0F1;
        public const ushort CSLootItemPacket = 0x038;
        public const ushort CSLootCloseBagPacket = 0x04A;
        public const ushort CSLootDicePacket = 0x026;
        public const ushort CSSellBackpackGoodsPacket = 0x024;
        public const ushort CSSellItemsPacket = 0x13E;
        public const ushort CSListSoldItemPacket = 0x110;
        public const ushort off_399F7AFC = 0x0EC;
        public const ushort CSStartTradePacket = 0x010;
        public const ushort CSCanStartTradePacket = 0x02E;
        public const ushort CSCannotStartTradePacket = 0x040;
        public const ushort CSCancelTradePacket = 0x121;
        public const ushort CSPutupTradeItemPacket = 0x10F;
        public const ushort CSTakedownTradeItemPacket = 0x0E7;
        public const ushort CSTradeLockPacket = 0x0D3;
        public const ushort CSTradeOkPacket = 0x00E;
        public const ushort CSPutupTradeMoneyPacket = 0x053;
        public const ushort off_399F7EDC = 0x0F7;

        // no such packets
        public const ushort CSSetCraftingPayPacket = 0xfff;
        public const ushort CSReplyExpeditionInvitationPacket = 0xfff;
        public const ushort CSResetQuestContextPacket = 0xfff;
        public const ushort CSReturnMailPacket = 0xfff;
        public const ushort CSSaveDoodadUccStringPacket = 0xfff;
        public const ushort CSSearchListPacket = 0xfff;
        public const ushort CSSetTeamOfficerPacket = 0xfff;
        public const ushort CSTakeAttachmentSequentiallyPacket = 0xfff;
        public const ushort CSSpecialtyRecordLoadPacket = 0xfff;
        public const ushort CSAcceptCheatQuestContextPacket = 0xfff;
        public const ushort CSBidAuctionPacket = 0xfff;
        public const ushort CSBuySpecialtyItemPacket = 0xfff;
        public const ushort CSChangeExpeditionSponsorPacket = 0xfff;
        public const ushort CSChangeSlaveTargetPacket = 0xfff;
        public const ushort CSCharDetailPacket = 0xfff;
        public const ushort CSSetupSecondPasswordPacket = 0xfff;
    }
}

