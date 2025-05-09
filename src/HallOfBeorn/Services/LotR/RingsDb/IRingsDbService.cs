﻿using System;
using System.Collections.Generic;
using HallOfBeorn.Models.RingsDb;

namespace HallOfBeorn.Services.LotR.RingsDb
{
    public interface IRingsDbService
    {
        string GetSlug(string cardId);
        string GetCardId(string slug);
        byte GetPopularity(string slug);
        uint GetVotes(string slug);
        IEnumerable<KeyValuePair<string, int>> GetLinks(string slug);
        bool DeckIncludesCard(string deckId, string slug);
        RingsDbDeckList GetDeckList(string deckId);
        IEnumerable<RingsDbDeckList> GetUserDecks(int userId);
        IEnumerable<RingsDbDeckList> FindDecks(IEnumerable<string> slugs);
        IEnumerable<string> GetDeckLabels(string deckId);
    }
}
