using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EvilCollisionHandler : MonoBehaviour
{
    public ParticleSystem ps;
    [SerializeField] LayerMask Projectile;
    [SerializeField] int playerhealth = 10;
    [SerializeField] int bosshealth = 50;
    [SerializeField] TextMeshProUGUI playerHP;
    [SerializeField] TextMeshProUGUI bossHP;
    [SerializeField] PlayerDamageSoundHandler playerDamageSound;
    [SerializeField] GameObject trophyPrefab;
    [SerializeField] MusicBoxHandler musicbox;

    // Start is called before the first frame update
    void Start()
    {
        ps = GetComponent<ParticleSystem>();
    }

    public void UpdateBossHP(int damage) {
        bossHP.text = "Boss HP - " + (bosshealth - damage);
        bosshealth -= 1;
        if (bosshealth <= 0) {
            // victory
            musicbox.StopMusic();
            Instantiate(trophyPrefab, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }

    void OnParticleCollision(GameObject collider) {
        if (collider.CompareTag("Player")) {
            playerDamageSound.PlaySound();
            print("Hit!!!");
            playerhealth -= 1;
            if (playerhealth <= 0) {
                SceneManager.LoadScene("FinalStage");
            }
            playerHP.text = "Player HP - " + playerhealth;
        }
    }
}
