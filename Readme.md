# Demo2 — 2D Shooter Game (Unity)

---

## Giới thiệu
Demo2 là một dự án game 2D thể loại shooter/arcade phát triển bằng Unity. Người chơi điều khiển nhân vật, tiêu diệt kẻ thù, thu thập vật phẩm năng lượng, đối mặt với boss và trải nghiệm hệ thống hiệu ứng, âm thanh, UI hiện đại.

---

## Mục đích dự án
- Xây dựng mẫu game shooter 2D hoàn chỉnh, dễ mở rộng.
- Làm nền tảng cho các dự án học tập, nghiên cứu hoặc phát triển game indie.
- Minh họa các kỹ thuật lập trình game: quản lý prefab, hệ thống âm thanh, xử lý input, hiệu ứng va chạm, quản lý scene.

---

## Gameplay & Tính năng nổi bật
- Di chuyển và bắn để tiêu diệt nhiều loại kẻ thù (basic, energy, explosion, heal, ...).
- Thu thập vật phẩm Energy để tăng thanh năng lượng; khi đạt ngưỡng sẽ kích hoạt sự kiện gọi boss.
- Boss có cơ chế tấn công đặc biệt (bắn vòng, sinh mini-enemy) và phần thưởng khi bị tiêu diệt.
- Hệ thống máu, hiển thị thanh HP, hiệu ứng va chạm, âm thanh và hiệu ứng nổ.
- Nhiều prefab kẻ thù, đạn, vật phẩm, dễ thêm/điều chỉnh bằng Unity Inspector.
- Hệ thống âm thanh (AudioManager) riêng để quản lý hiệu ứng và nhạc nền.
- Hệ thống UI: hiển thị HP, năng lượng, điểm số, thông báo sự kiện.
- Tối ưu cho build Windows, dễ mở rộng sang các nền tảng khác.

---

## Hướng dẫn điều khiển
| Hành động         | Phím mặc định         |
|-------------------|----------------------|
| Di chuyển         | WASD / phím mũi tên  |
| Bắn               | Chuột trái           |
| Nạp đạn           | R                    |
| Tạm dừng          | Esc                  |
| Thu vật phẩm      | Di chuyển qua vật phẩm|

> Các phím có thể chỉnh sửa trong Inspector hoặc file `InputSystem_Actions.inputactions`.

---

## Cấu trúc thư mục
```
Demo2/
├── Assets/
│   ├── Scripts/           # Chứa toàn bộ script C# của game
│   ├── Prefabs/           # Prefab kẻ thù, đạn, vật phẩm, hiệu ứng
│   ├── Scenes/            # Scene mẫu, các scene khác
│   ├── Sprites/           # Tài nguyên hình ảnh
│   ├── Animations/        # Animation cho nhân vật, enemy, hiệu ứng
│   ├── Ui/                # UI, HUD, thanh máu, năng lượng
│   └── Settings/          # Input System, cấu hình
├── ProjectSettings/       # Cấu hình dự án Unity
├── README.md              # Tài liệu dự án
└── ...
```

---

## Mô tả chi tiết các script chính
| Script                | Chức năng chính |
|-----------------------|-----------------|
| GameManager.cs        | Quản lý trạng thái game, điểm số, sự kiện gọi boss, kết thúc game |
| Player.cs             | Điều khiển di chuyển, xử lý máu, nhận sát thương, tương tác vật phẩm |
| Gun.cs                | Quản lý cơ chế bắn, cooldown, nạp đạn, spawn đạn |
| PlayerCollision.cs    | Xử lý va chạm giữa người chơi và các đối tượng (enemy, item) |
| Enemy.cs              | Lớp cha cho các loại kẻ thù, xử lý di chuyển, nhận sát thương |
| BasicEnemy.cs         | Kẻ thù cơ bản, di chuyển đơn giản, tấn công trực tiếp |
| BossEnemy.cs          | Kẻ thù boss, nhiều giai đoạn tấn công, sinh mini-enemy |
| HealEnemy.cs          | Kẻ thù hồi máu, khi tiêu diệt sẽ rơi vật phẩm hồi máu |
| EnergyEnemy.cs        | Kẻ thù năng lượng, khi tiêu diệt sẽ rơi vật phẩm Energy |
| ExplosionEnemy.cs     | Kẻ thù nổ, khi chết sẽ gây sát thương diện rộng |
| PLayerBullet.cs       | Đạn của người chơi, va chạm với enemy |
| EnemyBullet.cs        | Đạn của kẻ thù, va chạm với người chơi |
| AudioManager.cs       | Quản lý phát hiệu ứng âm thanh, nhạc nền, gọi từ các script khác |

---

## Hướng dẫn cài đặt & chạy project
### Yêu cầu hệ thống
- Unity 2021 trở lên (khuyến nghị bản LTS)
- Windows 10/11 hoặc macOS/Linux (có thể build đa nền tảng)
- RAM >= 4GB

### Các bước chạy nhanh
1. Mở Unity Hub, chọn project này (thư mục chứa `Assets/` và `ProjectSettings/`).
2. Vào menu `File` -> `Build Settings...`.
3. Chọn platform là `Windows` (hoặc nền tảng mong muốn).
4. Thêm scene `Assets/Scenes/SampleScene.unity` vào danh sách Scenes In Build.
5. Nhấn nút `Build`, chọn thư mục xuất bản.
6. Đợi quá trình build hoàn tất, mở file `.exe` trong thư mục xuất bản để chơi game.
7. Nếu gặp lỗi build, kiểm tra lại cấu hình trong `ProjectSettings` (graphics, input, player settings).

### Hướng dẫn chi tiết cho developer
- Các script đều có comment giải thích chức năng, dễ mở rộng.
- Có thể thêm enemy mới bằng cách tạo prefab và kế thừa từ `Enemy.cs`.
- Sử dụng Unity Inspector để chỉnh sửa tham số (máu, tốc độ, tần suất spawn, ...).
- Âm thanh, sprite, animation đều tách riêng, dễ thay đổi.

---

## Lưu ý cấu hình input
- Cấu hình phím và hành vi input có thể được định nghĩa trong `Assets/Settings/InputSystem_Actions.inputactions` và các script `Player.cs`, `Gun.cs`.
- Nếu không sử dụng Input System mới, kiểm tra các script để biết phím mặc định. (Giả định phổ biến: di chuyển bằng WASD/arrow, bắn bằng chuột/trái, nạp đạn bằng R). Kiểm tra file script nếu cần xác thực chính xác.

---

## Đóng góp & phát triển
- Pull request, issue, góp ý đều được chào đón!
- Vui lòng tạo branch riêng cho mỗi tính năng hoặc bugfix.
- Đảm bảo code tuân thủ chuẩn C# và Unity.
- Thêm tài liệu, comment cho các phần code mới.

---

## License
- Tài nguyên đồ họa sử dụng từ Craftpix, các asset miễn phí khác (xem chi tiết trong thư mục `Assets/` và file `Licens.txt`).
- Code được phát hành theo MIT License.

---

## Liên hệ & hỗ trợ
- Tác giả: sonbui18
- Email: buison357@gmail.com
- Github: https://github.com/sonbui18/Demo2
