public class TestGearB : Gear
{
    protected override void Start()
    {
        base.Start();
    }

    public override void Tick()
    {
        //print($"{nowCog}번째 톱니 할당 숫자: {nowCogNumber}");

        text.text = "Gear 2 nothing";

        base.Tick();
    }

    public override void Round()
    {
        //print("한 바퀴");
    }

    public override void Skill()
    {
        text.text = "Gear 2 Skill";
    }

    public override void CollaborateSkill()
    {
        text.text = "Gear 2 collaboration";
    }
}
