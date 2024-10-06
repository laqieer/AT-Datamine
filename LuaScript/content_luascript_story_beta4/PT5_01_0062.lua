-- このluaスクリプトは、PT5_01_0062.csvから自動生成されました --
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
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_03_015,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_015)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_03_017,"content_motion3d_advarea_common_adv_templatecontroller","Npc_015_01_StdController","to Std_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_017)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110011_03_016,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_016)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110011_03_011,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_011)
	InitializeTemplateRandomCamera110011_03()
	InitializeTemplate110011_03()
-- ▼直接出力
hideobj01 =get_object("geo_desk_item_02")
-- ▲直接出力
-- ▼直接出力
hideobj02 =get_object("geo_desk_item_04")
-- ▲直接出力
-- ▼直接出力
hideobj03 =get_object("geo_desk_item_07")
-- ▲直接出力
-- ▼直接出力
hideobj04 =get_object("geo_desk_item_10")
-- ▲直接出力
-- ▼直接出力
hideobj05 =get_object("geo_desk_item_13")
-- ▲直接出力
-- ▼直接出力
set_pos(hideobj01,{0,-20,0})
-- ▲直接出力
-- ▼直接出力
set_pos(hideobj02,{0,-20,0})
-- ▲直接出力
-- ▼直接出力
set_pos(hideobj03,{0,-20,0})
-- ▲直接出力
-- ▼直接出力
set_pos(hideobj04,{0,-20,0})
-- ▲直接出力
-- ▼直接出力
set_pos(hideobj05,{0,-20,0})
-- ▲直接出力
-- ▼直接出力
hideobj06 =get_object("geo_desk_item_06")
-- ▲直接出力
-- ▼直接出力
hideobj07 =get_object("geo_desk_item_01")
-- ▲直接出力
-- ▼直接出力
set_pos(hideobj06,{0,-20,0})
-- ▲直接出力
-- ▼直接出力
set_pos(hideobj07,{0,-20,0})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115020)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101066","001","101066001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor005")
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ブレイズ", "笑い")
-- ▲直接出力

	--★★ブレイズ★★:お主たちのおかげで<br>ワシのバルバロイ研究も進んでおってな
	Talk(Actor003,"CHRNAME_BLAZE","speech","L","PT5_01_00620003")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ブレイズ★★:先日、驚きの新事実が明らかになったのじゃよ<br>なんじゃと思う？えーと、ギネヴィ…
	Talk(Actor003,"CHRNAME_BLAZE","speech","L","PT5_01_00620004")

-- ▼直接出力
PlayPartVoice("ブレイズ", "肯定2")
-- ▲直接出力

	--★★ブレイズ★★:ガウェイン
	Talk(Actor003,"CHRNAME_BLAZE","speech","L","PT5_01_00620005")

-- ▼直接出力
PlayPartVoice("ガウェイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:えーっ、俺！？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT5_01_00620006")

	change_face(Actor001,"Sad")

	--★★ノワール★★:（ギネヴィア…）
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00620007")

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
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101066","001","101066001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor005")
	system.PreLoadRequest(CameraAssetBundleName110011_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
