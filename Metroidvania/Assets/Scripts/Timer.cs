using UnityEngine;

public class Timer
{
    private float duration;                 // ���� ����
    private float remainingTime;            // ���� �ð�
    private bool isRunning;                 // ���� ������ �Ǵ�

    public Timer(float duration)            // Ŭ���� ������ [Ŭ������ ������� �� �ʱ�ȭ]
    {
        this.duration = duration;
        this.remainingTime = duration;
        this.isRunning = false;
    }

    public void Start()                     // ��ŸƮ �����ֱ⿡�� ����� �� ���� ���� ���ִ� �Լ�
    {
        this.remainingTime = duration;      // Ȥ�� �𸣴� �ѹ� �� �ʱ�ȭ
        this.isRunning = true;
    }
    
    public void Update(float deltaTime)     // Update �Լ����� DeltaTime�� �޾ƿ´�.
    {
        if(isRunning)                       // ���� �� �϶�
        {
            remainingTime -= deltaTime;     // �޾ƿ� DeltaTime�� ���� ��Ų��.

            if(remainingTime <= 0)          // �ð��� �� �Ҹ� �Ǹ�
            {
                isRunning = false;          // ���� ����
                remainingTime = 0;          // ���� �ð� 0
            }
        }
    }

    public bool IsRunning()                 // ���� �� Ȯ�� �Լ�
    {
        return isRunning;                   // ���� ���� ��ȯ
    }

    public float GetRemainingTime()         // �����ִ� �ð� Ȯ�� �Լ�
    {
        return remainingTime;               // �ð� ���� ��ȯ
    }

    public void Reset()                     // �ʱ�ȭ �����ִ� �Լ�
    {
        this.remainingTime = duration;
        this.isRunning = false;
    }
}
