using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VfxManager : MonoBehaviour
{
    public AudioClip pointsClip;
    public AudioClip gameOverClip;
    public AudioClip jumpClip;


    private void Start()
    {
        Locator.Instance.player.getPoint += playPointsClip;
        Locator.Instance.player.gameOver += playGameOverClip;
        Locator.Instance.player.jump += playJumpClip;
    }

    public void playPointsClip()
    {
        AudioSource.PlayClipAtPoint(pointsClip, transform.position);
    }

    public void playGameOverClip()
    {
        AudioSource.PlayClipAtPoint(gameOverClip, transform.position);
    }

    public void playJumpClip()
    {
        AudioSource.PlayClipAtPoint(jumpClip, transform.position);
    }
}
