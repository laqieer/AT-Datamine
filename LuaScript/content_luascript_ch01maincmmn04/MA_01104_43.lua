-- このluaスクリプトは、MA_01104_43.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110061_03","110061_03_h")
Include("content_adv_advsmall_110061_03","Template110061_03_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110061_03_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110061_03,CameraPos110061_03_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110061_03_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110061_03,CameraPos110061_03_008)
	InitializeTemplateRandomCamera110061_03()
	InitializeTemplate110061_03()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115061)
	Actor001 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor002")
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_No")

	--★★マルディサント★★:こんなトコで走ってんじゃねぇよ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_430002")

	change_face(Actor001,"Sad")

	--★★ディナタン★★:…こんなトコで音読してた人に言われたくない
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_430003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マルディサント★★:…悪かったよ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_430005")


	--★★マルディサント★★:よくわかんねぇけど、なんか<br>言われたくねぇことあったんだろ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_430006")

	PlayAction(Actor001,"to  Std_No")

	--★★ディナタン★★:…ううん<br>マルディサントは悪くないよ
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_430008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ディナタン★★:ただ…あの本が<br>面白くなさそうって思っただけ
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_430009")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★マルディサント★★:当たり
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_430010")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ディナタン★★:え？
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_430011")


	--★★マルディサント★★:パラパラめくってみたけどさ<br>超つまんなそうだった、あの本
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_430012")

	change_face(Actor001,"Sad")

	--★★ディナタン★★:………だよね
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_430013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★マルディサント★★:もっとリアルでさ、泥臭ぇの期待してたのに<br>なんかさ、ウソくせえことばっか書いてあんの
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_430014")


	--★★ディナタン★★:…だよね
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_430015")


	--★★マルディサント★★:あれならアタシのほうが<br>よっぽど面白いの書けるね
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_430016")

-- ▼直接出力
turn(Actor001,0, 167.848, 0, 0.3)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ディナタン★★:マルディサントが…？
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_430017")

	PlayAction(Actor002,"to  Std_No")

	--★★マルディサント★★:なんでもねー、わすれろ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_430019")

	change_face(Actor001,"Sad")

	--★★ディナタン★★:…じゃあ、書き直してよ
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_430020")


	--★★マルディサント★★:あ？
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_430021")


	--★★ディナタン★★:信じられないくらい<br>良い話にしてみせてよ
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_430022")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Sad")

	--★★マルディサント★★:…学園のミナサマの共有物に<br>落書きはできませんなあ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_430023")

	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Normal")

	--★★ディナタン★★:じゃあ、隠さない？<br>本棚の奥の方に
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_430024")

-- ▼直接出力
setup_small_camera_end(Camera002)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルディサント★★:アンタがどーしてそんなに<br>この本にこだわるか知らねえが、乗ったぜ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_430025")


	--★★マルディサント★★:そもそも書庫の奥の方にあったヤツなんだ<br>目立たねえ奥まったとこに置いとこうぜ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_430026")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Angry")

	--★★ディナタン★★:じゃあ、じゃあ左右にいっぱい本詰めて<br>取り出しにくくしたらいいかもね…
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_430027")


	--★★マルディサント★★:………アンタ<br>結構ワルくなってきたな
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_430028")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115061)
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor002")
MobsNo = 0
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110061_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
