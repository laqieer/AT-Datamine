-- このluaスクリプトは、MA_01A109_901.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112041_03","112041_03_h")
Include("content_adv_advsmall_112041_03","Template112041_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",0,CharaPos112041_03_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_006)
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
	load_area_scene(112041)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101065","001","101065001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401027","001","401027001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
 --PlayPartVoice("キッス", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★キッス★★:あら、いらっしゃい♪<br>今日はどんなご用かしら？
	Talk(Actor002,"CHRNAME_KISS","speech","L","MA_01A109_9010002")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:キッスさん<br>憲兵団の仕事の依頼ってないかな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_9010003")


	--★★ノワール★★:ここんところご無沙汰だったし<br>大きな戦いも終わって落ち着いたってのもあるし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_9010004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("キッス", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★キッス★★:うーん<br>もちろんないわけじゃないんだけど…
	Talk(Actor002,"CHRNAME_KISS","speech","L","MA_01A109_9010005")

	change_face(Actor002,"Normal")

	--★★キッス★★:ロンディニウムの一件以来<br>ログレスに反発する声があちこちで上がってて
	Talk(Actor002,"CHRNAME_KISS","speech","L","MA_01A109_9010006")

	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Sad")

	--★★キッス★★:巡回に行った先で付近の住人と<br>揉めごとになっちゃうこともあるのよ
	Talk(Actor002,"CHRNAME_KISS","speech","L","MA_01A109_9010007")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:だからこそ、なんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_9010008")

-- ▼直接出力
 --PlayPartVoice("キッス", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★キッス★★:えっ？
	Talk(Actor002,"CHRNAME_KISS","speech","L","MA_01A109_9010009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:みんなの誤解を解くためには<br>地道に活動して、伝えていくしかないと思う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_9010010")


	--★★ノワール★★:円卓の騎士が最前線に立ってね
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_9010011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("キッス", "納得")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★キッス★★:そう、わかったわ
	Talk(Actor002,"CHRNAME_KISS","speech","L","MA_01A109_9010012")

	change_face(Actor002,"Normal")

	--★★キッス★★:ちょうどさっきロンディニウム周辺で<br>バルバロイ出没の報せがあったの
	Talk(Actor002,"CHRNAME_KISS","speech","L","MA_01A109_9010013")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("キッス", "肯定2")
-- ▲直接出力

	--★★キッス★★:その調査と、実際にバルバロイを確認した場合の<br>討伐をお願いできるかしら？
	Talk(Actor002,"CHRNAME_KISS","speech","L","MA_01A109_9010014")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:了解、行ってくるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_9010015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("キッス", "肯定")
-- ▲直接出力

	--★★キッス★★:くれぐれも、気を付けて
	Talk(Actor002,"CHRNAME_KISS","speech","L","MA_01A109_9010016")

-- ▼直接出力
 --reserve_next_script("β4メイン追加/MA_01A109_902")
-- ▲直接出力
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
	load_area_scene_preload(112041)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101065","001","101065001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401027","001","401027001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112041_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
