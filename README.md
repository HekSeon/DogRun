# <h1 align="center">🐾 DogRun — 3D Action Runner Game</h1>

# 

# <p align="center">

# &nbsp; <b>Unity・C#・3Dアクション / 個人制作プロジェクト</b><br>

# &nbsp; 高速ランゲーム × 障害回避 × アニメーション制御

# </p>

# 

# <p align="center">

<img src="https://img.shields.io/badge/Engine-Unity-000000?logo=unity\&style=for-the-badge">

<img src="https://img.shields.io/badge/Language-C%23-239120?logo=csharp\&style=for-the-badge">

<img src="https://img.shields.io/badge/Platform-PC-blue?style=for-the-badge">

<img src="https://img.shields.io/badge/Status-Active-success?style=for-the-badge">

# </p>

# 

# ---

# 

# \## 🎮 ゲーム概要 / Game Overview

# 

# DogRunは、プレイヤーが犬キャラクターを操作し、  

# 障害物を避けながら高速で走り続ける 3D ランナーゲーム です。

# 

# Unity のアニメーション、物理システム、カメラ制御を組み合わせ、  

# シンプルながら “爽快感” と “反応速度” が問われるゲームプレイを目指しました。

# ---

# 

# \## 🧩 主な特徴 / Key Features

# 

# \### 🐶 キャラクターアニメーション

# \- Idle / Run / Jump などの基本モーション  

# \- StateMachine による自然な遷移  

# 

# \### 🧱 障害物生成 \& ランダム配置システム

# \- プレイヤー前方に一定距離ごとに障害物スポーン  

# \- 難易度に応じてスピードや密度が変化  

# 

# \### 🏃 直感的で分かりやすい操作性

# \- W/A/S/D でレーン移動  

# \- Space でジャンプ  

# \- スムーズなカメラ追従  

# 

# \### ⚙️ 軽量・高速な最適化

# \- 非アクティブ化によるオブジェクト再利用  

# \- 毎フレームの負荷軽減  

# \- モバイル移植を想定した軽量設計  

# 

# ---

# 

# \## 🛠 使用技術 / Tech Stack

# 

# | 分類 | 内容 |

# |------|------|

# | ゲームエンジン | Unity 6000.0.47f1 |

# | 言語 | C# |

# | レンダリング | Built-in Pipeline |

# | アニメーション | Mecanim / Animator Controller |

# | 物理演算 | Rigidbody / BoxCollider / SphereCollider |

# | シーン構成 | MainScene + Prefab-based Architecture |

# | バージョン管理 | Git / GitHub |

# 

# ---

# 

# \## 📂 プロジェクト構造 / Directory Structure

# DogRun/

# ├── Assets/

# │ ├── Scripts/ # すべてのC#スクリプト

# │ ├── Animations/ # アニメーションクリップ \& コントローラ

# │ ├── Models/ # キャラクターモデル \& 障害物モデル

# │ ├── Materials/ # マテリアル \& テクスチャ

# │ ├── Prefabs/ # キャラ・障害物プレハブ

# │ ├── Scenes/ # MainScene.unity

# │ └── …

# ├── ProjectSettings/

└── README.md


===

# ---

# 

# \## 🚀 実行方法 / How to Run

# 

# \### 🔹 方法①：Unity Editor で直接起動  

# bash

# git clone https://github.com/HekSeon/DogRun.git

# cd DogRun

\# Unity Hub でプロジェクトを開く

対応 Unity Version：6000.0.47f1
===

# 

# シーン: Assets/Scenes/MainScene.unity

# 

# 🔹 方法②：ビルド版を実行（※後で追加可能）

# 

# GitHub Releases にアップロードされた .exe を起動

# 

# 🧠 学んだこと / What I Learned

# 

# Animator Controller と StateMachine の構築

# 

# 物理挙動と衝突判定の調整

# 

# レーンベースの移動処理

# 

# Update / FixedUpdate の使い分け

# 

# 軽量なゲームループ設計

# 

# 🔮 今後のアップデート / Future Improvement

# 

# 敵AIの追加

# 

# スコア / UI の実装

# 

# モバイル向け操作スキーム

# 

# パーティクルエフェクトの追加

# 

# ランダム生成アルゴリズム強化

# 

# 👤 作者 / Author

# 

# BAYAR SEMIH (HekSeon)

# HAL東京ゲームプログラマー学科 / 新卒ゲームプログラマー

# DirectX11・Unity・Unreal によるゲーム開発を学習中。





