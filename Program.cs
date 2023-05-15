int FindMinRotatingDiceSurface(List<int> diceList)
{
    Dictionary<int, int> diceValueCountDic = new Dictionary<int, int>();
    Dictionary<int, int> diceRotatingCountDic = new Dictionary<int, int>();

    GetCountOfDiceNumber(diceList, diceValueCountDic);

    int rotatingCount = 0,
     oppositeDiceNumber;

    for (int targetDiceNumber = 1; targetDiceNumber <= 6; targetDiceNumber++)
    {
        //There is no surface for this dice number
        if (diceValueCountDic[targetDiceNumber] == 0)
        {
            continue;
        }

        oppositeDiceNumber = 7 - targetDiceNumber;

        rotatingCount = diceValueCountDic[oppositeDiceNumber] * 2;
        rotatingCount += diceValueCountDic.Where(s => s.Key != oppositeDiceNumber
        && s.Key != targetDiceNumber).Sum(s => s.Value);

        diceRotatingCountDic.Add(targetDiceNumber, rotatingCount);
    }

    return diceRotatingCountDic.MinBy(s => s.Value).Key;
}

static void GetCountOfDiceNumber(List<int> diceList, Dictionary<int, int> diceValueCountDic)
{
    diceValueCountDic.Add(1, diceList.Count(s => s == 1));
    diceValueCountDic.Add(2, diceList.Count(s => s == 2));
    diceValueCountDic.Add(3, diceList.Count(s => s == 3));
    diceValueCountDic.Add(4, diceList.Count(s => s == 4));
    diceValueCountDic.Add(5, diceList.Count(s => s == 5));
    diceValueCountDic.Add(6, diceList.Count(s => s == 6));
}

List<int> diceNumberList = new List<int>();

diceNumberList.Add(1);
diceNumberList.Add(1);
diceNumberList.Add(1);
diceNumberList.Add(1);
diceNumberList.Add(1);
diceNumberList.Add(2);
diceNumberList.Add(2);
diceNumberList.Add(2);
diceNumberList.Add(2);
diceNumberList.Add(2);
diceNumberList.Add(2);
diceNumberList.Add(2);
diceNumberList.Add(2);
diceNumberList.Add(2);
diceNumberList.Add(2);
diceNumberList.Add(3);
diceNumberList.Add(3);
diceNumberList.Add(3);
diceNumberList.Add(3);
diceNumberList.Add(3);
diceNumberList.Add(3);
diceNumberList.Add(3);
diceNumberList.Add(4);
diceNumberList.Add(6);
diceNumberList.Add(6);

Console.WriteLine(FindMinRotatingDiceSurface(diceNumberList));

Console.ReadLine();



