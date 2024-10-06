-- このluaスクリプトは、MA_01B112_23.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_01","110071_01_h")
Include("content_adv_advsmall_110071_01","Template110071_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_001)
	Camera002 = SetTemplate("Actor002",104.8,CharaPos110071_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_002)
	Camera003 = SetTemplate("Actor003",120,CharaPos110071_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_003)
	Camera004 = SetTemplate("Actor004",-70.4,CharaPos110071_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Npc_503_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_008)
	Camera005 = SetTemplate("Actor005",128,CharaPos110071_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_004)
	Camera006 = SetTemplate("Actor006",-32.2,CharaPos110071_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_006)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110071_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_007)
	InitializeTemplateRandomCamera110071_01()
	InitializeTemplate110071_01()
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101041","003","101041003","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101028","002","101028002","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor007")
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
	change_face(Actor004,"Anger")

	--★★モルガン★★:アーサー、まって
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01B112_230002")

	PlayAction(Actor003,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("アーサー", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★アーサー★★:心配は無用だ、義姉さん<br>あのあたりの地理に詳しい人間がいるし
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B112_230003")


	--★★アーサー★★:最凶騎士と剣を交えた<br>頼もしい円卓の騎士たちもいる
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B112_230005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力

	--★★アーサー★★:遅れを取ることなど
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B112_230007")

	change_face(Actor004,"Sad")

	--★★モルガン★★:遅れたっていいのよ<br>もう止めはしないけれど
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01B112_230008")

-- ▼直接出力
 --PlayPartVoice("モルガン", "悲しみ")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★モルガン★★:必死に貴方を止めた家族がいる<br>貴方を待っている者がいる
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01B112_230009")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★モルガン★★:それだけ、覚えていて
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01B112_230010")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★アーサー★★:…ああ。義姉さん
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B112_230011")


	--★★モルガン★★:ノワールくんも…<br>どうか潰れてしまわないで
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01B112_230012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★モルガン★★:貴方が背負うものは、重すぎる
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01B112_230013")

	open_select_window_tag(Actor001,"Normal","MA_01B112_230014","MA_01B112_230015")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:『最強騎士』がついてます<br>ひとりで背負うわけじゃありませんから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_230017")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ランスロット★★:ノワールにはまだ識るべきことが残っています<br>俺にはそれをともに抱える義務がある
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B112_230018")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:俺はこいつから離れません
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B112_230020")

-- ▼直接出力
 --PlayPartVoice("モルガン", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★モルガン★★:ありがとう、ランスロット
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01B112_230021")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:しばらく前までは見つけてほしくて<br>このコートを羽織っていたけれど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_230023")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:後輩ができました<br>カッコ悪い姿は見せられません
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_230024")

-- ▼直接出力
 --PlayPartVoice("モルガン", "納得")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★モルガン★★:…なら、こちらのカワイイ後輩クン？<br>我が校の英雄を見習って──
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01B112_230026")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Normal")

	--★★モルガン★★:王も騎士も<br>守ってあげてくれる？
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01B112_230028")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "肯定3")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ガラハッド★★:あいわかった<br>任せてもらおう！
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01B112_230029")

	goto Block1end

::Block1end::
	change_face(Actor004,"Sad")

	--★★モルガン★★:アーサー<br>どうか先にいかないで
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01B112_230031")

-- ▼直接出力
 --PlayPartVoice("モルガン", "悲しみ")
-- ▲直接出力

	--★★モルガン★★:そんな親不孝、許さないから
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01B112_230032")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101041","003","101041003","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101028","002","101028002","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor007")
MobsNo = 0
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
