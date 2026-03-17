using System;
using System.Collections.Generic;
using System.Text;

class BidComparer: Comparer<AuctionItem>
{
    public override int Compare(AuctionItem x, AuctionItem y)
    {
        if(x == null && y == null)
        {
            return 0;
        }
        if(x == null)
        {
            return -1;
        }
        if(y == null)
        {
            return 1;
        }
        if(y.CurrentBid.CompareTo(x.CurrentBid) != 0)
        {
            return y.CurrentBid.CompareTo(x.CurrentBid);
        }
        return x.Name.CompareTo(y.Name);
    }
}
