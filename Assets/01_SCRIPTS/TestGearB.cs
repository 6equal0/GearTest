public class TestGearB : Gear
{
    protected override void Start()
    {
        base.Start();
    }

    public override void Tick()
    {
        //print($"{nowCog}��° ��� �Ҵ� ����: {nowCogNumber}");

        text.text = "Gear 2 nothing";

        base.Tick();
    }

    public override void Round()
    {
        //print("�� ����");
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
