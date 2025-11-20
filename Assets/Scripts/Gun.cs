using UnityEngine;
using TMPro;

public class Gun : MonoBehaviour
{
    private float rotateOffset = 180f;
    [SerializeField] private Transform firePos;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float shootDelay = 0.15f; // Thời gian giữa các phát bắn (giây)
    private float nextShot;
    [SerializeField] private int maxAmmo = 24;
    [SerializeField] private int currentAmmo;
    [SerializeField] private TextMeshProUGUI ammoText;
    [SerializeField] private AudioManager audioManager;
    [SerializeField] private float reloadTime = 1.5f; // Thời gian chờ nạp đạn (giây)
    private bool isReloading = false;
    private float reloadTimer = 0f;

    void Start()
    {
        currentAmmo = maxAmmo;
        UpdateAmmoText();
    }


    void Update()
    {
        RotateGun();
        Shoot();
        Reload();
        HandleReloadTimer();
    }

    // Xoay súng để hướng về con trỏ chuột
    void RotateGun()
    {
        if (Input.mousePosition.x < 0 || Input.mousePosition.x > Screen.width || Input.mousePosition.y < 0 || Input.mousePosition.y > Screen.height)
        {
            return;
        }
        Vector3 displacement = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float angle = Mathf.Atan2(displacement.y, displacement.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle + rotateOffset);
        if (angle > 90 || angle < -90)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            transform.localScale = new Vector3(1, -1, 1);
        }
    }

    // Bắn đạn
    void Shoot()
    {
        if( isReloading)
        {
            return;
        }
        if (Input.GetMouseButton(0) && Time.time > nextShot && currentAmmo > 0)
        {
            Instantiate(bulletPrefab, firePos.position, firePos.rotation);
            nextShot = Time.time + shootDelay;
            currentAmmo--;
            UpdateAmmoText();
            audioManager.PlayShootSound();
        }
    }

    // Nạp đạn
    void Reload()
    {
        if (!isReloading && (Input.GetKeyDown(KeyCode.R) || Input.GetMouseButtonDown(1)) && currentAmmo < maxAmmo || (currentAmmo == 0 && !isReloading))
        {
            isReloading = true;
            reloadTimer = reloadTime;
            audioManager.PlayReLoadSound();
        }
        
    }


    // Cập nhật hiển thị đạn
    private void UpdateAmmoText()
    {
        if(ammoText != null)
        {
            if (isReloading)
            {
                ammoText.text = $"{reloadTimer:F2}s";
            }
            else if (currentAmmo > 0)
            {
                ammoText.text = currentAmmo.ToString();
            }
            else
            {
                ammoText.text = "Empty";
            }
        }
    }

    // Xử lý hẹn giờ nạp đạn
    private void HandleReloadTimer()
    {
        if (isReloading)
        {
            reloadTimer -= Time.deltaTime;
            if (reloadTimer > 0f)
        {
            UpdateAmmoText();
        }
        else
        {
            currentAmmo = maxAmmo;
            isReloading = false;
            UpdateAmmoText();
            }
        }
    }
}
