-- このluaスクリプトは、EA_009_021.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_04","110011_04_h")
Include("content_adv_advsmall_110011_04","Template110011_04_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_04_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_04_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_005)
	InitializeTemplateRandomCamera110011_04()
	InitializeTemplate110011_04()
-- ▼直接出力
set_pos(Actor002,{2.13,0,-6.0})
Hide(Actor002)
-- ▲直接出力
-- ▼直接出力
RndCamera001 = RndCamera005
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
on_active(Actor002)
PlayActionDirect(Actor002,"to Run")
turn_lookat_position(Actor002,CharaPos110011_04_005[1],CharaPos110011_04_005[2],CharaPos110011_04_005[3],0)
slidemove(Actor002,CharaPos110011_04_005[1],CharaPos110011_04_005[2],CharaPos110011_04_005[3],1.3)
wait_time(1.25)
setup_small_camera_start(Camera002)
wait_time(0.05)
PlayActionDirect(Actor002,"to Std_Loop")
turn_chara(Actor002,CharaPos110011_04_005[4],0.15)
wait_time(0.6)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("男子1","0002")
-- ▲直接出力

	--★★男子生徒A★★:ノワール！大変だ！
	Talk(Actor002,"NPCNAME_0151","speech","N","EA_009_0210004")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0007")
-- ▲直接出力

	--★★ノワール★★:どうしたんだよ、そんなに慌てて
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0210005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Angry")

	--★★男子生徒A★★:これが慌てずにいられるか！俺たちのアイドルが<br>療養院に運ばれたんだぞ！
	Talk(Actor002,"NPCNAME_0151","speech","N","EA_009_0210006")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0028")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:なんだって！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0210007")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("男子1","0007")
-- ▲直接出力

	--★★男子生徒A★★:なんでも、街の外にバルバロイの討伐に出て<br>そこでなにかあったみたいで…早く行ってやれ！
	Talk(Actor002,"NPCNAME_0151","speech","N","EA_009_0210008")

-- ▼直接出力
voice_play("VO_101009_sp_0003_3")
-- ▲直接出力
	change_face(Actor001,"Pain")

	--★★ノワール★★:ディナタン…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0210009")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
RndCamera001 = RndCamera005
	InitializeLoad_Preload()
	load_area_scene_preload(110011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("401005","001","401005001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
