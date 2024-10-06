-- このluaスクリプトは、MA_01104_904.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112041_03","112041_03_h")
Include("content_adv_advsmall_112041_03","Template112041_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-20,CharaPos112041_03_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112041_03_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_508_01_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos112041_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_018_01_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_005)
	InitializeTemplateRandomCamera112041_03()
	InitializeTemplate112041_03()
-- ▼直接出力
set_enable_auto_lookat(Actor003,false)
sakabin = setup_prop_object(10101015)
sakabin_offset2 = {0,0,0,0,0,0}
on_parent(sakabin ,Actor003, "Loc_weapon_constrint_R", sakabin_offset2 )
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(116044)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101065","001","101065001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401027","001","401027001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")
	change_face(Actor002,"Smile")

	--★★キッス★★:いらっしゃい、ラビットちゃん<br>待ってたわよ♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","MA_01104_9040002")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:キッスさん<br>バルバロイ掃討作戦は無事終わったよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_9040003")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★キッス★★:ああ、うん、聞いてるわ<br>それより早速新しい仕事が来てるの
	Talk(Actor002,"CHRNAME_KISS","speech","L","MA_01104_9040004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:えっ、もう？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_9040005")

	change_face(Actor002,"Sad")

	--★★キッス★★:最近多いのよね～、この手の案件<br>ホントはアタシの管轄外なんだけど…
	Talk(Actor002,"CHRNAME_KISS","speech","L","MA_01104_9040006")

	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Surprise")

	--★★キッス★★:あっ、ごめんなさい！<br>ラビットちゃんに愚痴ってもしょうがないわね
	Talk(Actor002,"CHRNAME_KISS","speech","L","MA_01104_9040007")

	change_face(Actor002,"Normal")

	--★★キッス★★:１週間後にね、今日とは違う場所で<br>同じようにバルバロイ掃討作戦を行うらしいの
	Talk(Actor002,"CHRNAME_KISS","speech","L","MA_01104_9040008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★キッス★★:ラビットちゃん<br>よかったら次も参加してもらえないかしら？
	Talk(Actor002,"CHRNAME_KISS","speech","L","MA_01104_9040009")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ノワール★★:今回と同じ内容なんだな？<br>それならお安い御用だ。任せてくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_9040010")

	PlayAction(Actor002,"to  Std_Joy")
	change_face(Actor002,"Smile")

	--★★キッス★★:そう言ってくれると思ってたわ<br>よろしく頼むわね♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","MA_01104_9040011")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10101015)
sakabin_offset2 = {0,0,0,0,0,0}
	InitializeLoad_Preload()
	load_area_scene_preload(116044)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101065","001","101065001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401027","001","401027001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112041_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
