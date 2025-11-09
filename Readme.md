
## Demo2 — Game 2D Shooter (Mô tả dự án)

Mục đích
- Đây là một project game 2D (Unity) dạng shooter/arcade: người chơi điều khiển nhân vật, bắn kẻ thù, thu vật phẩm năng lượng, và đối mặt với boss khi đạt đủ năng lượng.

Tổng quan gameplay
- Người chơi di chuyển và bắn để tiêu diệt nhiều loại kẻ thù (basic, energy, explosion, heal, ...).
- Thu thập vật phẩm Energy để tăng thanh năng lượng; khi đạt ngưỡng sẽ kích hoạt sự kiện gọi boss.
- Boss có cơ chế tấn công đặc biệt (ví dụ: bắn vòng, sinh mini-enemy) và có phần thưởng khi bị tiêu diệt.
- Có hệ thống máu, hiển thị thanh HP, hiệu ứng va chạm, âm thanh và hiệu ứng nổ.

Điểm nổi bật
- Nhiều prefab kẻ thù và đạn, dễ thêm/điều chỉnh bằng Unity Inspector.
- Hệ thống âm thanh (AudioManager) riêng để quản lý hiệu ứng và nhạc nền.

Chạy project (tóm tắt)
1. Mở Unity Hub và load project (thư mục gốc chứa `Assets/` và `ProjectSettings/`).
2. Mở scene mẫu: `Assets/Scenes/SampleScene.unity` và nhấn Play.
3. Xem các thành phần trong Inspector (Player, EnemySpawner, GameManager) để tinh chỉnh tham số (máu, tốc độ, tần suất spawn,...).

Lưu ý cấu hình input
- Cấu hình phím và hành vi input có thể được định nghĩa trong `Assets/Settings/InputSystem_Actions.inputactions` và các script `Player.cs`, `Gun.cs`.
- Nếu không sử dụng Input System mới, kiểm tra các script để biết phím mặc định. (Giả định phổ biến: di chuyển bằng WASD/arrow, bắn bằng chuột/trái, nạp đạn bằng R). Kiểm tra file script nếu cần xác thực chính xác.

Tệp và lớp chính (vị trí trong `Assets/Scripts/`)
- `GameManager.cs` — quản lý trạng thái game, spawn boss, điểm/giành chiến thắng.
- `Player.cs` — logic di chuyển người chơi, health và tương tác.
- `Gun.cs` — cơ chế bắn, tái nạp, spawn đạn.
- `PlayerCollision.cs` — xử lý va chạm giữa người chơi và đối tượng.
- `Enemy.cs`, `BasicEnemy.cs`, `BossEnemy.cs`, `HealEnemy.cs`, `EnergyEnemy.cs`, `ExplosionEnemy.cs` — các logic kẻ thù khác nhau.
- `PLayerBullet.cs` / `EnemyBullet.cs` — logic đạn của người chơi và kẻ thù.
- `AudioManager.cs` — quản lý hiệu ứng âm thanh và nhạc nền.

Thư mục quan trọng
- `Assets/Prefabs/` — chứa prefab của kẻ thù, đạn, vật phẩm, hiệu ứng.
- `Assets/Scenes/` — chứa scene mẫu `SampleScene.unity`.
- `Assets/Animations/`, `Assets/Sprites/`, `Assets/Ui/` — tài nguyên đồ họa và UI.

Hướng dẫn build nhanh
- Để build bản Windows: mở File -> Build Settings, chọn platform Windows, thêm scene `SampleScene.unity` vào Build, rồi bấm Build.
- Kiểm tra `ProjectSettings` (graphics, input) nếu cần thay đổi hành vi trên nền tảng đích.

Gợi ý mở rộng (next steps)
- Thêm README chi tiết tiếng Anh nếu định chia sẻ public.
- Viết tài liệu về cấu trúc prefab và cách tạo enemy mới.
- Thêm hướng dẫn build tự động / script xuất bản nếu cần nhiều môi trường.

Credits & Liên hệ
- Tác giả/nhóm: (chưa điền). Thêm thông tin tác giả tại đây nếu muốn.

---

Nếu bạn muốn, mình có thể mở rộng phần này: thêm hướng dẫn điều khiển chính xác, mô tả chi tiết từng script hoặc hướng dẫn build step-by-step (kèm ảnh chụp màn hình). Hãy cho biết chi tiết bạn muốn đưa vào README.
