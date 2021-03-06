﻿/* 
 * This file was automatically generated.
 * Do not modify, changes will get lost when the file is regenerated!
 */
using System;

namespace Octgn.Server
{
	interface IClientCalls
	{ 
		void Binary();
		void Error(string msg);
		void Kick(string reason);
		void Welcome(byte id, Guid gameSessionId, bool waitForGameState);
		void Settings(bool twoSidedTable, bool allowSpectators, bool muteSpectators);
		void PlayerSettings(byte playerId, bool invertedTable, bool spectator);
		void NewPlayer(byte id, string nick, ulong pkey, bool tableSide, bool spectator);
		void Leave(byte player);
		void Nick(byte player, string nick);
		void Start();
		void Reset(byte player);
		void NextTurn(byte nextPlayer, bool force);
		void StopTurn(byte player);
		void Chat(byte player, string text);
		void Print(byte player, string text);
		void Random(int result);
		void Counter(byte player, int counter, int value, bool isScriptChange);
		void LoadDeck(int[] id, Guid[] type, int[] group, string[] size, string sleeve, bool limited);
		void CreateCard(int[] id, Guid[] type, string[] size, int group);
		void CreateCardAt(int[] id, Guid[] modelId, int[] x, int[] y, bool faceUp, bool persist);
		void CreateAliasDeprecated(int[] id, ulong[] type);
		void MoveCard(byte player, int[] id, int group, int[] idx, bool[] faceUp, bool isScriptMove);
		void MoveCardAt(byte player, int[] id, int[] x, int[] y, int[] idx, bool[] faceUp, bool isScriptMove);
		void Peek(byte player, int card);
		void Untarget(byte player, int card, bool isScriptChange);
		void Target(byte player, int card, bool isScriptChange);
		void TargetArrow(byte player, int card, int otherCard, bool isScriptChange);
		void Highlight(int card, string color);
		void Turn(byte player, int card, bool up);
		void Rotate(byte player, int card, CardOrientation rot);
		void ShuffleDeprecated(int group, int[] card);
		void Shuffled(byte player, int group, int[] card, short[] pos);
		void UnaliasGrpDeprecated(int group);
		void UnaliasDeprecated(int[] card, ulong[] type);
		void AddMarker(byte player, int card, Guid id, string name, ushort count, ushort origCount, bool isScriptChange);
		void RemoveMarker(byte player, int card, Guid id, string name, ushort count, ushort origCount, bool isScriptChange);
		void TransferMarker(byte player, int from, int to, Guid id, string name, ushort count, ushort origCount, bool isScriptChange);
		void PassTo(byte player, int id, byte to, bool requested);
		void TakeFrom(int id, byte to);
		void DontTake(int id);
		void FreezeCardsVisibility(int group);
		void GroupVis(byte player, int group, bool defined, bool visible);
		void GroupVisAdd(byte player, int group, byte who);
		void GroupVisRemove(byte player, int group, byte who);
		void LookAt(byte player, int uid, int group, bool look);
		void LookAtTop(byte player, int uid, int group, int count, bool look);
		void LookAtBottom(byte player, int uid, int group, int count, bool look);
		void StartLimited(byte player, Guid[] packs);
		void CancelLimited(byte player);
		void CardSwitchTo(byte player, int card, string alternate);
		void PlayerSetGlobalVariable(byte player, string name, string oldval, string val);
		void SetGlobalVariable(string name, string oldval, string val);
		void Ping();
		void IsTableBackgroundFlipped(bool isFlipped);
		void PlaySound(byte player, string name);
		void Ready(byte player);
		void PlayerState(byte player, byte state);
		void RemoteCall(byte player, string function, string args);
		void GameStateReq(byte player);
		void GameState(byte toPlayer, string state);
		void DeleteCard(int card, byte player);
		void PlayerDisconnect(byte player);
		void AddPacks(byte player, Guid[] packs, bool selfOnly);
		void AnchorCard(int id, byte player, bool anchor);
		void SetCardProperty(int id, byte player, string name, string val, string valtype);
		void ResetCardProperties(int id, byte player);
		void Filter(int card, string color);
		void SetBoard(string name);
		void SetPlayerColor(byte player, string color);
		void SetPhase(byte phase, byte nextPhase, bool force);
		void StopPhase(byte player, byte phase);
	}
}
