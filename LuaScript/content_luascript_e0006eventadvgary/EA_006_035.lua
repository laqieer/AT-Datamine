-- このluaスクリプトは、EA_006_035.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110122_03","110122_03_h")
Include("content_adv_advsmall_110122_03","Template110122_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110122_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleName110122_03,CameraPos110122_03_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110122_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName110122_03,CameraPos110122_03_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110122_03_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110122_03,CameraPos110122_03_004)
	InitializeTemplateRandomCamera110122_03()
	InitializeTemplate110122_03()
-- ▼直接出力
set_pos(Actor003,{7.33, 0, -11.89})
turn_lookat(Actor003,Actor001,0)
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor001,Actor002,0)
-- ▲直接出力
-- ▼直接出力
load_image("201010690", "content_still_20101069_image", "201010690_StillImage")
-- ▲直接出力
-- ▼直接出力
Camera_EX = set_camera({2.342, 2.769, -3.644,   14.589, 135.716, 0,   25})
-- ▲直接出力
-- ▼直接出力
Camera_EX2 = set_camera({5.14, 2.28, -9.69,   17.534, 134.496, 0,   25})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110122)
	Actor001 = InitializeCharacter_3D("101032","002","101032002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Joy")
	change_face(Actor001,"Smile")

	--★★ガレス★★:――それで、助けてくれたお礼にって！
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0350002")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0010")
-- ▲直接出力

	--★★アーサー★★:おお、これはすごいな！<br>大量のニンニク、ハーブ、チーズ！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_006_0350003")

	change_face(Actor002,"Smile")

	--★★アーサー★★:いい香りなんだかクサいんだか<br>わけわからなくなってきたぞ！鼻もげそう！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_006_0350004")

-- ▼直接出力
setup_small_camera_start(Camera_EX)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ガレス","0010")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ガレス★★:ランスロットが手伝ってくれたおかげで<br>メイン以外の材料はほとんど揃ったぞ！
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0350005")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Smile")

	--★★ガレス★★:あとはメインを用意するだけだ～♪
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0350006")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0007")
-- ▲直接出力

	--★★アーサー★★:このひときわキツイ臭いは…ブルーチーズか！<br>クサいけど美味いんだよなぁ、これ！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_006_0350007")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.2)
PlayActionDirect(Actor002,"to Wlk")
turn_lookat(Actor002,Actor003,0.4)
wait_time(0.4)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.2)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★アーサー★★:ランス、ほら、嗅いでみろ！<br>そんな遠くにいないでこっちに来い！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_006_0350008")


	--★★ランスロット★★:遠慮する
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","EA_006_0350010")

	change_face(Actor002,"Smile")

	--★★アーサー★★:大丈夫！そんなにクサくないから！<br>ほら、ちょっとだけ！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_006_0350011")

-- ▼直接出力
setup_small_camera_end(Camera_EX)
setup_small_camera_start(Camera_EX2)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_No")
-- ▼直接出力
PlayPartVoiceDirect("ランスロット","0040")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ランスロット★★:絶対に嫌だ
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","EA_006_0350012")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.2)
setup_small_camera_end(Camera_EX2)
setup_small_camera_start(Camera_EX)
wait_time(0.2)
PlayActionDirect(Actor001,"to Wlk")
turn_lookat(Actor001,Actor003,0.8)
wait_time(0.8)
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(0.6)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ガレス","0034")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ガレス★★:もしかして、チーズが駄目なのか？
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0350013")


	--★★ランスロット★★:…チーズが、というよりは<br>臭いがキツいものが得意ではない
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","EA_006_0350014")

	change_face(Actor001,"Normal")

	--★★ガレス★★:
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0350015")

-- ▼直接出力
PlayPartVoiceDirect("アーサー","0009")
-- ▲直接出力

	--★★アーサー★★:
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_006_0350017")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ランスロット","0002")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ランスロット★★:余計なことは言わなくていい<br>そんなことより――
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","EA_006_0350018")

-- ▼直接出力
setup_small_camera_end(Camera_EX)
setup_small_camera_start(Camera_EX2)
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ランスロット★★:ガレスの円卓入りの件<br>俺も賛成派に加わらせてもらおう
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","EA_006_0350019")

-- ▼直接出力
setup_small_camera_end(Camera_EX2)
setup_small_camera_start(Camera_EX)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ガレス★★:え！
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0350020")

	change_face(Actor002,"Normal")

	--★★アーサー★★:理由を聞いても？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_006_0350021")

-- ▼直接出力
setup_small_camera_end(Camera_EX)
setup_small_camera_start(Camera_EX2)
-- ▲直接出力

	--★★ランスロット★★:元々、実力については問題ないと思っていた<br>だが円卓の騎士に必要なのはそれだけじゃない
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","EA_006_0350022")


	--★★ランスロット★★:窮地の者を即座に助けに行く姿勢<br>敵の注意を引くためにとった選択
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","EA_006_0350023")


	--★★ランスロット★★:そして民を背に守り、傷つけないよう配慮しつつ<br>速やかに危機を排除した手腕
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","EA_006_0350024")

-- ▼直接出力
setup_small_camera_end(Camera_EX2)
setup_small_camera_start(Camera_EX)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Smile")

	--★★ランスロット★★:弱気を助けるために戦うガレスの在りかたは<br>円卓の精神に適うと判断した。それが理由だ
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","EA_006_0350025")

	PlayAction(Actor001,"to  Std_Angry")
	change_face(Actor001,"Laugh")

	--★★ガレス★★:ランスロット…
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0350026")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.2)
PlayActionDirect(Actor002,"to Wlk")
turn_lookat(Actor002,Actor001,0.4)
wait_time(0.4)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.2)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★アーサー★★:ふむ。最強騎士のお墨付きか<br>やはり俺の目は確かというわけだな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_006_0350027")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.2)
PlayActionDirect(Actor001,"to Wlk")
turn_lookat(Actor001,Actor002,0.6)
wait_time(0.6)
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0010")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:ここまでくれば、モルドレッドはともかく<br>義兄さんは認めてくれるだろうさ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_006_0350028")

-- ▼直接出力
setup_small_camera_end(Camera_EX)
setup_small_camera_start(Camera001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ガレス","0038")
-- ▲直接出力

	--★★ガレス★★:そうだといいな！<br>けど、ウチの兄さんは――…
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0350029")

-- ▼直接出力
setup_small_camera_end(Camera001)
setup_small_camera_start(Camera002)
-- ▲直接出力

	--★★アーサー★★:心配ない<br>そのうち認めてくれるさ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_006_0350030")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.2)
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,307,0.7)
wait_time(0.7)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.6)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0008")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:家族想いだからな、ヒーローは
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_006_0350031")

-- ▼直接出力
CloseTalkWindow()
bgm_play("Stop_BGM_Bus_LongFade")
wait_time(0.4)
show_image("201010690", 0.0, 0.0, 0.8,true,false)
wait_time(0.8)
-- ▲直接出力

	--★★ガウェイン★★:………
	Talk(Actor004,"CHRNAME_GAWAIN","simple","N","EA_006_0350034")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("201010690", "content_still_20101069_image", "201010690_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110122)
	InitializeCharacter_3D_Preload("101032","002","101032002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110122_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
