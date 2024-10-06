-- このluaスクリプトは、MA_01B112_05.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_02","110051_02_h")
Include("content_adv_advsmall_110051_02","Template110051_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_007)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110051_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_008)
	Camera004 = SetTemplate("Actor004",10.9,CharaPos110051_02_013,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_013)
	Camera005 = SetTemplate("Actor005",25.41,CharaPos110051_02_012,"content_motion3d_advarea_common_adv_templatecontroller","Chr_516_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_012)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110051_02_011,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_011)
	InitializeTemplateRandomCamera110051_02()
	InitializeTemplate110051_02()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110051)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101036","001","101036001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_TextOnly()
	template1()
end

function Play()
	StartPlay()


	--★★テロップ★★:
	Talk(Actor007,"telop","narration","N","MA_01B112_051001")


	--★★テロップ★★:
	Talk(Actor007,"telop","narration","N","MA_01B112_051002")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力

	--★★テロップ★★:
	Talk(Actor007,"telop","narration","N","MA_01B112_051004")

-- ▼直接出力
 --スチル終了
CloseTalkWindow()
hide_image(1.0)
wait_time(2.4)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★フィエナ★★:もともとコルベニック城は<br>妖精ニニアンのために建てられたものなの
	Talk(Actor005,"CHRNAME_VIENA","speech","L","MA_01B112_050002")

	change_face(Actor005,"Sad")

	--★★フィエナ★★:けれど妖精が去り<br>もぬけの殻となった…
	Talk(Actor005,"CHRNAME_VIENA","speech","L","MA_01B112_050003")


	--★★パーシヴァル★★:銀卓騎士団は妖精の加護が残るその地を<br>守るべく組織された。だよね？
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","MA_01B112_050004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ボールス★★:その騎士団がなぜ我らを襲う？<br>なぜアーサー王を狙う？
	Talk(Actor003,"CHRNAME_BORS","speech","L","MA_01B112_050006")

	change_face(Actor005,"Normal")

	--★★フィエナ★★:おじい様たちの目的は<br>本当は違うの
	Talk(Actor005,"CHRNAME_VIENA","speech","L","MA_01B112_050007")

	PlayAction(Actor004,"to  Std_Surp")
	change_face(Actor004,"Surprise")

	--★★ガラハッド★★:えっ！？姉上…？<br>が、ガラハッドは知りませんが…！？
	Talk(Actor004,"CHRNAME_GALAHAD","speech","L","MA_01B112_050008")

	change_face(Actor005,"Sad")

	--★★フィエナ★★:私もお城を脱出するときに聞いただけだから<br>定かじゃなかったんだけど
	Talk(Actor005,"CHRNAME_VIENA","speech","L","MA_01B112_050009")


	--★★ノワール★★:…ライエンス王に襲われたときか<br>誰からなにを聞かされたんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_050010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★フィエナ★★:追い出されぎわ<br>アステラに囁かれたの──
	Talk(Actor005,"CHRNAME_VIENA","speech","L","MA_01B112_050011")

	PlayAction(Actor005,"to  Std_Talk")

	--★★フィエナ★★:──「銀卓騎士団とぺレス王は<br><dot>父なる彼の遺児</dot>を護る」と
	Talk(Actor005,"CHRNAME_VIENA","speech","L","MA_01B112_050012")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110051)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101036","001","101036001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor006")
	system.PreLoadRequest(CameraAssetBundleName110051_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
