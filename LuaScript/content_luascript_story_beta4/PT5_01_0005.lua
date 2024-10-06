-- このluaスクリプトは、PT5_01_0005.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_03","110011_03_h")
Include("content_adv_advsmall_110011_03","Template110011_03_h")
-- ▼直接出力
MobsNo = 2
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_03_017,"content_motion3d_advarea_common_adv_templatecontroller","Npc_015_01_StdController","to Std_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_017)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_03_016,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_016)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110011_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_001)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110011_03_015,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_015)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110011_03_006,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_006)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110011_03_011,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_011)
	InitializeTemplateRandomCamera110011_03()
	InitializeTemplate110011_03()
-- ▼直接出力
hideobj01 =get_object("geo_desk_item_02")
hideobj02 =get_object("geo_desk_item_04")
hideobj03 =get_object("geo_desk_item_07")
hideobj04 =get_object("geo_desk_item_10")
hideobj05 =get_object("geo_desk_item_13")
-- ▲直接出力
-- ▼直接出力
set_pos(hideobj01,{0,-20,0})
set_pos(hideobj02,{0,-20,0})
set_pos(hideobj03,{0,-20,0})
set_pos(hideobj04,{0,-20,0})
set_pos(hideobj05,{0,-20,0})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115020)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101066","001","101066001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor007")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ブレイズ", "挨拶")
-- ▲直接出力

	--★★ブレイズ★★:剣を持ったものや斧を持ったもの<br>魔法を使うものに空を飛ぶもの…
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00050002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ブレイズ★★:バルバロイにも様々な種類がおることは<br>みんなも知っておるな？
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00050003")


	--★★ブレイズ★★:文献によると、この世に現れ始めた当初<br>バルバロイは武器すら持たず
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00050004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ブレイズ", "肯定2")
-- ▲直接出力

	--★★ブレイズ★★:獣のように己の牙や爪を用いて<br>襲い掛かってくるだけだったようなのじゃが
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00050005")


	--★★ブレイズ★★:長い戦いを経て進化を遂げたのか
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00050006")


	--★★ブレイズ★★:それとも人間から奪った記憶や知識を活かし<br>個々の戦場に適応するようになったのか
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00050007")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ブレイズ★★:少しずつその姿や戦いかたを変えてきておる
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00050008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ブレイズ", "怒り")
-- ▲直接出力

	--★★ブレイズ★★:もしもこれから先、新種のバルバロイに<br>遭遇するようなことがあったら…
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00050009")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ブレイズ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ブレイズ★★:ワシへの報告を忘れずにな？<br>新種の研究はワクワクするからのう～！
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00050010")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115020)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101066","001","101066001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor007")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
