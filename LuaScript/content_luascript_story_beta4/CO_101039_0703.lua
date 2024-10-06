-- このluaスクリプトは、CO_101039_0703.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110021_01","110021_01_h")
Include("content_adv_advsmall_110021_01","Template110021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",272,CharaPos110021_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110021_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_514_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_007)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110021_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_513_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_003)
	Camera004 = SetTemplate("Actor004",75,CharaPos110021_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_001)
	InitializeTemplateRandomCamera110021_01()
	InitializeTemplate110021_01()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_ik_lookat(Actor001,Actor003,"J_Head")
lookat_weight(Actor001,0.55,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor002,Actor003,0)
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor003,"J_Head")
lookat_weight(Actor002,0.5,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor003,Actor002,0)
set_enable_auto_lookat(Actor003, false)
keep_ik_lookat(Actor003,Actor002,"J_Head")
lookat_weight(Actor003,0.5,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor004, false)
Hide(Actor004)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110021)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101039","001","101039001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101038","001","101038001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401009","001","401009001","content_animationpack__common","FacialPack","Actor004")
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("フレン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★フレン★★:あれっ、ローラ！<br>おっかえり～！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_07030002")

	PlayAction(Actor003,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ローラ", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ローラ★★:ただいま、お姉ちゃん<br>なんだか今日はいつもにも増して元気だね？
	Talk(Actor003,"CHRNAME_LOLA","speech","L","CO_101039_07030004")

-- ▼直接出力
PlayPartVoice("フレン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フレン★★:えへへ！<br>さっきね、いいことがあったんだよ
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_07030005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")

	--★★フレン★★:ルーシャスくんが<br>競技大会を開いてくれるかもなんだ
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_07030006")

	PlayAction(Actor004,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("男子1", "驚き")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）③★★:――本当か！？
	Talk(Actor004,"CHRNAME_NAMELES","speech","N","CO_101039_07030007")

-- ▼直接出力
 --ジーンの名前変更＆登場
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
--キャメロット騎士学術院（男）③,NPCNAME_0241 @名前変更
Appear(Actor004)
keep_ik_lookat(Actor001,Actor004,"J_Head")
keep_ik_lookat(Actor002,Actor004,"J_Head")
keep_ik_lookat(Actor003,Actor004,"J_Head")
keep_ik_lookat(Actor004,Actor002,"J_Head")
lookat_weight(Actor004,0.5,0.1,0.8,0.2)
change_face(Actor003,"Normal")
wait_time(CHARA_IN_WAIT)
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")

	--★★キャメロット騎士学術院（男）③★★:ルーシャス皇太子が<br>競技大会を開催してくれるのか！？
	Talk(Actor004,"NPCNAME_0241","speech","N","CO_101039_07030009")

-- ▼直接出力
PlayPartVoice("フレン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★フレン★★:「かも」だけどね<br>ルーシャスくんから条件を出されたんだ
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_07030010")


	--★★キャメロット騎士学術院（男）③★★:条件？
	Talk(Actor004,"NPCNAME_0241","speech","N","CO_101039_07030011")

-- ▼直接出力
PlayPartVoice("フレン", "肯定2")
-- ▲直接出力

	--★★フレン★★:陸上部内で起きているケンカを収めろって
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_07030012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("男子1", "悩む")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）③★★:それは…！<br>うーん、難しそうだな…
	Talk(Actor004,"NPCNAME_0241","speech","N","CO_101039_07030013")


	--★★キャメロット騎士学術院（男）③★★:ふたりのいがみ合いから始まって<br>部の雰囲気はどんどん険悪になってるからなあ
	Talk(Actor004,"NPCNAME_0241","speech","N","CO_101039_07030014")


	--★★キャメロット騎士学術院（男）③★★:俺もいつの間にか<br>ログレス側の代表にされてしまって
	Talk(Actor004,"NPCNAME_0241","speech","N","CO_101039_07030015")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("男子1", "悲しみ")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）③★★:ローマやその他の国の生まれの生徒たちから<br>白い目で見られる始末だよ
	Talk(Actor004,"NPCNAME_0241","speech","N","CO_101039_07030016")

	PlayAction(Actor004,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("男子1", "笑い")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）③★★:でも、フレンとノワールが<br>なんとかしてくれるんだよな！
	Talk(Actor004,"NPCNAME_0241","speech","N","CO_101039_07030017")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:えっ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_07030018")

-- ▼直接出力
if is_active(RndCamera090) == false then
DontChangeRandomCamera(true)
on_camera(Camera004)
end
-- ▲直接出力
	PlayAction(Actor004,"to Greet_one")
-- ▼直接出力
PlayPartVoice("男子1", "納得")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）③★★:いやー、そうか。競技大会が開催できるのか！<br>フレンにノワール、ありがとう！
	Talk(Actor004,"NPCNAME_0241","speech","N","CO_101039_07030019")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
Hide(Actor004)
setup_small_camera_start()
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor001,"J_Head")
keep_ik_lookat(Actor003,Actor002,"J_Head")
wait_time(CHARA_IN_WAIT)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("フレン", "悲しみ")
-- ▲直接出力

	--★★フレン★★:そのことで部長に<br>相談に乗ってもらおうと思ったんだけど…
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_07030021")

-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:やれやれ<br>俺たちでなんとかするしかないな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_07030022")

-- ▼直接出力
local trustParam = set_communication_rankup("フレン_コミュランク", "フレン_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
 --open_trust_gauge(Actor002, trustParam)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110021)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101039","001","101039001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101038","001","101038001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401009","001","401009001","content_animationpack__common","FacialPack","Actor004")
	system.PreLoadRequest(CameraAssetBundleName110021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
