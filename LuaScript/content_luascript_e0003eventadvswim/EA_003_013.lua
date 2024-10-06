-- このluaスクリプトは、EA_003_013.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112011_01","112011_01_h")
Include("content_adv_advsmall_112011_01","Template112011_01_h")
Include("content_adv_advsmall_112011_02","112011_02_h")
Include("content_adv_advsmall_112011_02","Template112011_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",96,CharaPos112011_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName112011_01,CameraPos112011_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112011_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName112011_01,CameraPos112011_01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos112011_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName112011_01,CameraPos112011_01_002)
	Camera004 = SetTemplate("Actor004",nil,CharaPos112011_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName112011_01,CameraPos112011_01_006)
	Camera005 = SetTemplate("Actor005",nil,CharaPos112011_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112011_01,CameraPos112011_01_007)
	Camera006 = SetTemplate("Actor006",200,CharaPos112011_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleName112011_01,CameraPos112011_01_001)
	Camera007 = SetTemplate("Actor007",nil,CharaPos112011_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName112011_01,CameraPos112011_01_004)
	InitializeTemplateRandomCamera112011_01()
	InitializeTemplate112011_01()
-- ▼直接出力
lookat_weight(Actor001,0.5,0.1,0.85,0.2)
keep_ik_lookat(Actor001,Actor002,"J_Head")
-- ▲直接出力
-- ▼直接出力
lookat_weight(Actor002,0.45,0.1,0.85,0.2)
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
Hide(Actor005)
-- ▲直接出力
-- ▼直接出力
Hide(Actor006)
-- ▲直接出力
-- ▼直接出力
Hide(Actor007)
-- ▲直接出力
-- ▼直接出力
RndCamera001 = RndCamera004
-- ▲直接出力
end
function template2()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",75,CharaPos112011_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName112011_02,CameraPos112011_02_001)
	Camera002 = SetTemplate("Actor002",315,CharaPos112011_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName112011_02,CameraPos112011_02_003)
	Camera003 = SetTemplate("Actor003",290,CharaPos112011_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName112011_02,CameraPos112011_02_002)
	Camera004 = SetTemplate("Actor004",107,CharaPos112011_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName112011_02,CameraPos112011_02_004)
	Camera005 = SetTemplate("Actor005",nil,CharaPos112011_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112011_02,CameraPos112011_02_008)
	Camera006 = SetTemplate("Actor007",nil,CharaPos112011_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName112011_02,CameraPos112011_02_007)
	InitializeTemplateRandomCamera112011_02()
	InitializeTemplate112011_02()
-- ▼直接出力
set_pos(Actor001,{1.592,0.074,2.611})
CUT_1 = set_camera({12.9823,2.81323,11.33552,13.57899,227.681,0,22})
-- ▲直接出力
-- ▼直接出力
set_pos(Actor002,{2.456,0.074,2.199})
-- ▲直接出力
-- ▼直接出力
set_pos(Actor003,{3.229,0.074,2.815})
-- ▲直接出力
-- ▼直接出力
set_pos(Actor004,{1.362,0.074,3.891})
-- ▲直接出力
-- ▼直接出力
Appear(Actor005)
-- ▲直接出力
-- ▼直接出力
Appear(Actor007)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112011)
	Actor001 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401008","001","401008001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ギネヴィア★★:来たわね、ディナタン
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_003_0130002")

-- ▼直接出力
PlayPartVoice("ディナタン", "肯定")
-- ▲直接出力

	--★★ディナタン★★:はい
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","EA_003_0130003")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("マルディサント", "挨拶")
-- ▲直接出力

	--★★マルディサント★★:オイ王妃様よぉ、こんな人気のないトコに<ruby=いたいけ>幼気</ruby>な後輩を呼びだすたぁどういう了見だ？
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","EA_003_0130004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor001)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Pointing")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ギネヴィア", "怒り")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:あなたのどこが幼気な後輩なのよ！それにわたしが話したいのはディナタンで…
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_003_0130005")

-- ▼直接出力
SkipDefaultMotion(Actor003)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("マルディサント", "怒り")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★マルディサント★★:あ？なめてんじゃねーぞディーナと話したいならまずアタシを通しな
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","EA_003_0130006")

-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ギネヴィア", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:ぐぬぬ…まぁ、この際あなたでもいいんだけど…
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_003_0130008")

-- ▼直接出力
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("マルディサント", "驚き")
-- ▲直接出力

	--★★マルディサント★★:あぁ？
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","EA_003_0130009")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ディナタン", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ディナタン★★:マァル、そのくらいにして～！すみません、ギネヴィア様！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","EA_003_0130010")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1.0)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:あの…私にお話ってなんでしょうか
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","EA_003_0130011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ギネマウア", "肯定2")
-- ▲直接出力

	--★★ギネマウア★★:ほら、殿下
	Talk(Actor004,"CHRNAME_GWENHWYMAWR","speech","L","EA_003_0130012")

-- ▼直接出力
SkipDefaultMotion(Actor001)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor001,false)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "肯定")
-- ▲直接出力

	--★★ギネヴィア★★:えっと、それは、あの…だからあれよ、その――
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_003_0130014")


	--★★ディナタン★★:？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","EA_003_0130015")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.0)
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
wait_time(2.0)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor001,true)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:………あなたに、聞きたいことがあるのよ！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_003_0130017")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0, FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
template2()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(CUT_1)
-- ▲直接出力
-- ▼直接出力
wait_time(TIME_ELAPSED)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to  Std_Talk")
-- ▲直接出力
-- ▼直接出力
fadein(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力
	PlayAction(Actor007,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("女子2", "肯定3")
-- ▲直接出力

	--★★女子生徒Ｂ★★:ほら！あれ見てディナタンがギネヴィア様に詰め寄られてる！
	Talk(Actor007,"NPCNAME_0147","speech","N","EA_003_0130019")

-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力

	--★★ノワール★★:確かに
	Talk(Actor005,"CHRNAME_NOIR","speech","L","EA_003_0130020")

-- ▼直接出力
SkipDefaultMotion(Actor007)
-- ▲直接出力
	PlayAction(Actor007,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("女子2", "驚き")
-- ▲直接出力

	--★★女子生徒Ｂ★★:もしや五月女王の座を奪われたギネヴィア様が嫉妬して、嫌がらせをしているのでは！？
	Talk(Actor007,"NPCNAME_0147","speech","N","EA_003_0130021")


	--★★女子生徒Ｂ★★:それとも学園のアイドルとしてディナタンがもてはやされることが気に入らなくて…！？
	Talk(Actor007,"NPCNAME_0147","speech","N","EA_003_0130022")

-- ▼直接出力
SkipDefaultMotion(Actor005)
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:ギネヴィアはそういうタイプじゃないだろ…ないと思う、たぶんだけど
	Talk(Actor005,"CHRNAME_NOIR","speech","L","EA_003_0130023")

-- ▼直接出力
setup_small_camera_start(Camera006)
-- ▲直接出力
	PlayAction(Actor007,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("女子2", "悩む")
-- ▲直接出力

	--★★女子生徒Ｂ★★:でも、じゃああれはなんなんなのよ気になってしょうがないわ
	Talk(Actor007,"NPCNAME_0147","speech","N","EA_003_0130024")

	PlayAction(Actor007,"to  Std_Surp")

	--★★女子生徒Ｂ★★:このままじゃ私不確かな情報を新聞部に提供してしまうわ！
	Talk(Actor007,"NPCNAME_0147","speech","N","EA_003_0130025")

-- ▼直接出力
PlayActionDirect(Actor007,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★ノワール★★:…わかったよ話を聞いてくればいいんだろ
	Talk(Actor005,"CHRNAME_NOIR","speech","L","EA_003_0130026")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor007,"to Wlk")
-- ▲直接出力
-- ▼直接出力
turn(Actor007,0,337,0,0.4)
-- ▲直接出力
-- ▼直接出力
wait_time(0.4)
-- ▲直接出力
	PlayAction(Actor007,"to Greet_one")
-- ▼直接出力
PlayPartVoice("女子2", "笑い")
-- ▲直接出力

	--★★女子生徒Ｂ★★:ありがと！あとで詳細教えてね！
	Talk(Actor007,"NPCNAME_0147","speech","N","EA_003_0130027")

	play_head_motion(Actor005, "No", 0.3, 1.0, false)

	--★★ノワール★★:まったく…
	Talk(Actor005,"CHRNAME_NOIR","speech","L","EA_003_0130029")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0, 2.0)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor005,"to Wlk")
-- ▲直接出力
-- ▼直接出力
slidemove(Actor005,7.413,0.074,6.898,2.0)
-- ▲直接出力
-- ▼直接出力
wait_time(2.0)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor005,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
wait_time(0.1)
-- ▲直接出力
-- ▼直接出力
template1()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(true)
-- ▲直接出力
-- ▼直接出力
Appear(Actor005)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor006,{3.68,0,7.52})
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
wait_time(TIME_ELAPSED)
-- ▲直接出力
-- ▼直接出力
fadein(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力
	open_select_window_tag(Actor005,"Normal","EA_003_0130031","EA_003_0130032")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ノワール★★:ギネヴィア、マルディサント！おい、落ち着けよふたりとも
	Talk(Actor005,"CHRNAME_NOIR","speech","L","EA_003_0130034")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ギネヴィア★★:の、ノワール！？なんでここに――
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_003_0130035")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("マルディサント", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★マルディサント★★:オニーサンに聞かれちゃ困る話でもしようとしてたってのか？
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","EA_003_0130036")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:そういうわけじゃなくて…
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_003_0130037")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor005,"J_Head",1.0)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:…あなた、今ひとりよね？他に誰もついてきてないわよね
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_003_0130039")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ノワール★★:あぁ
	Talk(Actor005,"CHRNAME_NOIR","speech","L","EA_003_0130040")

	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:よ、よかったぁ
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_003_0130041")

	change_face(Actor005,"Sad")

	--★★ノワール★★:？
	Talk(Actor005,"CHRNAME_NOIR","speech","L","EA_003_0130042")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ノワール★★:ディナタン、ギネマウアさんなぁ、なにがあったんだ？
	Talk(Actor005,"CHRNAME_NOIR","speech","L","EA_003_0130044")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:あ、兄さん。それがわからないの
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","EA_003_0130045")

	change_face(Actor002,"Sad")

	--★★ディナタン★★:ギネヴィア様からお呼び出しを受けて来てみたはいいんだけど…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","EA_003_0130046")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ギネマウア", "肯定")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ギネマウア★★:本題に入る前にこうなってしまいまして
	Talk(Actor004,"CHRNAME_GWENHWYMAWR","speech","L","EA_003_0130047")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ノワール★★:なるほど…
	Talk(Actor005,"CHRNAME_NOIR","speech","L","EA_003_0130048")

	PlayAction(Actor004,"to  Std_No")
-- ▼直接出力
PlayPartVoice("ギネマウア", "落胆")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ギネマウア★★:殿下の意気地がないばかりにもうしわけございません
	Talk(Actor004,"CHRNAME_GWENHWYMAWR","speech","L","EA_003_0130049")

	change_face(Actor005,"Sad")

	--★★ノワール★★:？？？
	Talk(Actor005,"CHRNAME_NOIR","speech","L","EA_003_0130050")

	goto Block1end

::Block1end::
	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★ノワール★★:ともかく、いったん落ち着こう
	Talk(Actor005,"CHRNAME_NOIR","speech","L","EA_003_0130052")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1.0)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:そうですよこのままじゃ話が進みません
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","EA_003_0130053")

-- ▼直接出力
PlayPartVoice("ギネヴィア", "肯定")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ギネヴィア★★:そ、そうね
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_003_0130054")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("マルディサント", "肯定3")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★マルディサント★★:ま、ディーナがいいっつーなら
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","EA_003_0130055")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1.0)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ディナタン", "挨拶")
-- ▲直接出力

	--★★ディナタン★★:あの、ギネヴィア様私になにか聞きたいことがあるんですよね？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","EA_003_0130056")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:…そうよ
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_003_0130057")

-- ▼直接出力
SkipDefaultMotion(Actor005)
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ノワール★★:ディナタンに聞きたいこと？いったいなにを…
	Talk(Actor005,"CHRNAME_NOIR","speech","L","EA_003_0130058")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Wlk")
-- ▲直接出力
-- ▼直接出力
turn(Actor001,0,20,0,0.5)
-- ▲直接出力
-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor001)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Pointing")
-- ▲直接出力

	--★★ギネヴィア★★:あなたも知ってるでしょあの張り紙のこと！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_003_0130060")

-- ▼直接出力
PlayActionDirect(Actor005,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★ノワール★★:え？
	Talk(Actor005,"CHRNAME_NOIR","speech","L","EA_003_0130061")

-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")

	--★★ギネヴィア★★:『学園一のアイドルと学園一の非行少女の絆！』
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_003_0130062")

-- ▼直接出力
SkipDefaultMotion(Actor001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Joy")

	--★★ギネヴィア★★:『水と油のふたりがどうやってGSをするまでの絆を紡ぐに至ったのであろうか』…！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_003_0130063")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ディナタン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:…え、なにそれそんな話になってるの？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","EA_003_0130065")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Wlk")
-- ▲直接出力
-- ▼直接出力
turn(Actor001,0,75,0,0.4)
-- ▲直接出力
-- ▼直接出力
wait_time(0.4)
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.0)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor001)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:ねえ、教えてよ！どうすればタイプ違う人と友達になれるの！？
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_003_0130066")

-- ▼直接出力
SkipDefaultMotion(Actor001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0042")
-- ▲直接出力
	open_cutin(1,2)
	on_cutin(1,Actor001,"Anger")
	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:友達の作りかた、教えてよ！！！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","N","EA_003_0130067")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
	close_cutin()
-- ▼直接出力
wait_time(1.0)
-- ▲直接出力

	--★★ノワール／ディナタン／マルディサント★★:………
	Talk(Actor008,"CHRNAME_NOIR_DINATAN_MALADISANT","speech","N","EA_003_0130068")

-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor004,Actor005,"J_Head",1.0)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ギネマウア", "落胆")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ギネマウア★★:要するに、殿下はお友達作りが下手なのです
	Talk(Actor004,"CHRNAME_GWENHWYMAWR","speech","L","EA_003_0130069")

-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力

	--★★ノワール★★:お友達作りが下手…
	Talk(Actor005,"CHRNAME_NOIR","speech","L","EA_003_0130070")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネマウア", "肯定2")
-- ▲直接出力

	--★★ギネマウア★★:ええ昔はこれほどではなかったのですが
	Talk(Actor004,"CHRNAME_GWENHWYMAWR","speech","L","EA_003_0130071")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ギネマウア★★:学園に来てからは変に拗ねてしまったこともあって
	Talk(Actor004,"CHRNAME_GWENHWYMAWR","speech","L","EA_003_0130072")

-- ▼直接出力
SkipDefaultMotion(Actor005)
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ノワール★★:つまり…ふたりがどうやって仲良くなったのか参考にしたいってことか
	Talk(Actor005,"CHRNAME_NOIR","speech","L","EA_003_0130073")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("マルディサント", "落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★マルディサント★★:なんだよ、カツアゲじゃねーのかよつまんね
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","EA_003_0130074")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor001,"J_Head",1.0)
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★マルディサント★★:まぁ、よく考えたらこの人がそんなタマなわけねぇか
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","EA_003_0130075")

-- ▼直接出力
SkipDefaultMotion(Actor001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "怒り")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ギネヴィア★★:どういう意味よぉ！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_003_0130076")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:たぶん、いい意味ですよ。でも困ったなぁマァルとどう仲良くなったかと言われても…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","EA_003_0130077")

-- ▼直接出力
PlayPartVoice("マルディサント", "納得")
-- ▲直接出力

	--★★マルディサント★★:まぁ、王妃殿下にはオススメしづらいよな
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","EA_003_0130078")

-- ▼直接出力
SkipDefaultMotion(Actor003)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("マルディサント", "笑い")
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★マルディサント★★:なんたってアタシとディーナは、腹を割っての<ruby=マジバト>本気のぶつかり合い</ruby>で仲深めたからな～
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","EA_003_0130079")

-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ギネヴィア", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ギネヴィア★★:<ruby=マジバト>本気のぶつかり合い</ruby>…？
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_003_0130080")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",1.0)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ディナタン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:ちょ、マァル！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","EA_003_0130081")

-- ▼直接出力
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor005,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor005,"Laugh")

	--★★ノワール★★:あぁ、あれは大変だったよなぁ
	Talk(Actor005,"CHRNAME_NOIR","speech","L","EA_003_0130083")

	PlayAction(Actor005,"to  Std_Talk")

	--★★ノワール★★:妹の知らない一面を見たっていうかアイドルにしてはなかなかカゲキな…
	Talk(Actor005,"CHRNAME_NOIR","speech","L","EA_003_0130084")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ディナタン", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ディナタン★★:兄さんも余計なこと言わなくていいから！！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","EA_003_0130085")

-- ▼直接出力
SkipDefaultMotion(Actor001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:なるほど…つまり、バトルをすればいいってこと…？
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_003_0130086")

-- ▼直接出力
PlayPartVoice("ディナタン", "否定")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:あの、ギネヴィアさんそれは――
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","EA_003_0130087")

-- ▼直接出力
Appear(Actor006)
set_enable_auto_lookat(Actor001,false)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ティルフィング", "挨拶")
-- ▲直接出力

	--★★ティルフィング★★:ここにいらっしゃいましたか、マスター
	Talk(Actor006,"CHRNAME_TYRFING","speech","L","EA_003_0130088")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor006,"J_Head",0.5)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor005,"to Wlk")
-- ▲直接出力
-- ▼直接出力
turn(Actor005,0,34,0,0.5)
-- ▲直接出力
-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor005,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ギネヴィア★★:！！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_003_0130089")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
lookat_delay_weight_reset(Actor001,1.0)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Run")
-- ▲直接出力
-- ▼直接出力
turn(Actor001,0,306.5345,0,0.2)
-- ▲直接出力
-- ▼直接出力
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
slidemove(Actor001,{-1.317,0.04065,7.308},1.8)
-- ▲直接出力
-- ▼直接出力
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor004,"to Wlk")
-- ▲直接出力
-- ▼直接出力
turn(Actor004,0,308.7909,0,0.8)
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor004,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor006,"to Wlk")
-- ▲直接出力
-- ▼直接出力
slidemove(Actor006,{3.602,0.074,3.609},3.0)
-- ▲直接出力
-- ▼直接出力
play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▲直接出力
-- ▼直接出力
wait_time(1.0)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
Hide(Actor001)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor004,"to Wlk")
-- ▲直接出力
-- ▼直接出力
slidemove(Actor004,{-1.317,0.04065,7.308},3.0)
-- ▲直接出力
-- ▼直接出力
wait_time(1.3)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor005,"to Wlk")
-- ▲直接出力
-- ▼直接出力
turn(Actor005,0,149,0,0.5)
-- ▲直接出力
-- ▼直接出力
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor006,"J_Head",1.0)
keep_delay_ik_lookat(Actor003,Actor006,"J_Head",1.0)
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,3,0.2)
wait_time(0.1)
PlayActionDirect(Actor003,"to Wlk")
turn_chara(Actor003,-8,0.3)
wait_time(0.1)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor005,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
wait_time(0.2)
turn(Actor006,0,287,0,0.2)
-- ▲直接出力
-- ▼直接出力
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor006,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor004,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
Hide(Actor004)
wait_time(0.5)
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ノワール★★:ティルフィング。どうかしたか？
	Talk(Actor005,"CHRNAME_NOIR","speech","L","EA_003_0130091")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
lookat_delay_weight(Actor006,0.45,0.1,0.85,0.2,1.0)
-- ▲直接出力
	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定")
-- ▲直接出力

	--★★ティルフィング★★:はい。ランスロット卿がマスターをお呼びです
	Talk(Actor006,"CHRNAME_TYRFING","speech","L","EA_003_0130092")

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:わかった。この話が終わったら行くよ…あれ？ギネヴィアは？
	Talk(Actor005,"CHRNAME_NOIR","speech","L","EA_003_0130093")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("マルディサント", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★マルディサント★★:コソコソしながら行っちまったぜ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","EA_003_0130094")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor005, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★ノワール★★:なんで？話は終わったのか？？
	Talk(Actor005,"CHRNAME_NOIR","speech","L","EA_003_0130095")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ディナタン", "悩む")
-- ▲直接出力

	--★★ディナタン★★:さぁ…さっきの答えで納得できてたらいいけどううん、されても困るんだけど
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","EA_003_0130096")

-- ▼直接出力
SkipDefaultMotion(Actor005)
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ノワール★★:なんだかよくわからないなそれになんで今更友達の作りかたなんて…
	Talk(Actor005,"CHRNAME_NOIR","speech","L","EA_003_0130097")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor006,"J_Head",1.0)
wait_time(1.0)
change_face(Actor002,"Surprise")
keep_delay_ik_lookat(Actor006,Actor002,"J_Head",0.7)
wait_time(1.0)
-- ▲直接出力

	--★★ティルフィング★★:…？なにか？
	Talk(Actor006,"CHRNAME_TYRFING","speech","L","EA_003_0130099")

-- ▼直接出力
PlayPartVoice("ディナタン", "納得")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:…私、理由わかったかも
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","EA_003_0130100")

-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor005,"to Std_Loop")
-- ▲直接出力

	--★★ノワール★★:え？
	Talk(Actor005,"CHRNAME_NOIR","speech","L","EA_003_0130101")

-- ▼直接出力
set_enable_auto_lookat(Actor005, true)
set_enable_auto_lookat(Actor006,true)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor006,"J_Head",1.0)
wait_time(0.8)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("マルディサント", "肯定2")
-- ▲直接出力

	--★★マルディサント★★:あー、そういうことかまったく手のかかる王妃サマだ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","EA_003_0130102")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, true)
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor005,"J_Head",0.8)
-- ▲直接出力
-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:応援してあげてね、兄さん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","EA_003_0130103")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor005, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★ノワール★★:いや、何を…？
	Talk(Actor005,"CHRNAME_NOIR","speech","L","EA_003_0130104")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
RndCamera001 = RndCamera004
	InitializeLoad_Preload()
	load_area_scene_preload(112011)
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("401008","001","401008001","content_animationpack__common","FacialPack","Actor007")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112011_01)
	system.PreLoadRequest(CameraAssetBundleName112011_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
