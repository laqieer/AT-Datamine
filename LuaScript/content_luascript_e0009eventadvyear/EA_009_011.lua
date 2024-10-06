-- このluaスクリプトは、EA_009_011.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_03","110111_03_h")
Include("content_adv_advsmall_110111_03","Template110111_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_03_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110111_03,CameraPos110111_03_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110111_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName110111_03,CameraPos110111_03_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110111_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110111_03,CameraPos110111_03_002)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110111_03_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_03,CameraPos110111_03_003)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110111_03_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110111_03,CameraPos110111_03_006)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110111_03_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110111_03,CameraPos110111_03_007)
	InitializeTemplateRandomCamera110111_03()
	InitializeTemplate110111_03()
-- ▼直接出力
BgProp = setup_prop_object(10102012)
set_pos(BgProp,{0,0,0})
-- ▲直接出力
-- ▼直接出力
set_pos(Actor006,{6.548, 0, -14.125})
-- ▲直接出力
-- ▼直接出力
set_pos(Actor005,{6.82, 0, -13.27})
-- ▲直接出力
-- ▼直接出力
turn_chara(Actor006,30,0)
turn_chara(Actor005,206,0)
turn_chara(Actor001,350,0)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor006,false)
set_enable_auto_lookat(Actor005,false)
set_common_look_at(Actor006,Actor005)
set_common_look_at(Actor005,Actor006)
-- ▲直接出力
-- ▼直接出力
Camera_EX = set_camera({4.41, 1.26, -12.13,   359.772, 126.9992, 0.37759,   30.36522})
-- ▲直接出力
-- ▼直接出力
Camera_EX2 = set_camera({8.15, 1.45, -12,   3.59, -123.977, -0.339,   30.36522})
-- ▲直接出力
-- ▼直接出力
set_pos(Actor002,{3.98, 0, -14.79})
set_pos(Actor003,{3.74, 0, -15.28})
set_pos(Actor004,{3.76, 0, -15.13})
turn_chara(Actor004, 234.0252,0)
turn_chara(Actor003,   235,0)
Hide(Actor002)
Hide(Actor003)
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Painful2")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115119)
	Actor001 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101030","002","101030002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Surprise")

	--★★ディナタン★★:わ～、なんだかこの辺りも<br>キラキラしてていつもと雰囲気違う
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_009_0110006")

-- ▼直接出力
PlayPartVoiceDirect("ディナタン","0010")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ディナタン★★:降誕祭だから特別な飾りつけなのかなぁ<br>見てるだけでワクワクしてきちゃう
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_009_0110007")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.6)
PlayActionDirect(Actor001,"to Wlk")
turn_lookat(Actor001,Actor005,0.4)
wait_time(0.4)
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(1.4)
setup_small_camera_start(Camera_EX)
wait_time(0.8)
PlayActionDirect(Actor005,"to  Std_Talk")
wait_time(1.0)
PlayActionDirect(Actor006,"to  Std_Sad01")
wait_time(0.6)
PlayActionDirect(Actor005,"to Std_Loop")
wait_time(0.8)
PlayActionDirect(Actor006,"to Std_Loop")
wait_time(0.4)
setup_small_camera_end(Camera_EX)
setup_small_camera_start(Camera_EX2)
wait_time(0.8)
PlayActionDirect(Actor005,"to  Std_Talk")
wait_time(1.0)
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,180,0.3)
wait_time(0.4)
setup_small_camera_end(Camera_EX2)
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(0.6)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_No")

	--★★ディナタン★★:…それにしても兄さん、遅いなぁ～
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_009_0110009")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ディナタン★★:
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_009_0110010")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.4)
setup_small_camera_end(Camera001)
setup_small_camera_start(RndCamera003)
PlayActionDirect(Actor005,"to Std_Loop")
Appear(Actor004)
Appear(Actor003)
Appear(Actor002)
wait_time(0.4)
PlayActionDirect(Actor004,"to Wlk")
slidemove(Actor004,{0.445, 0, -18.679},2.8,2.8)
PlayActionDirect(Actor003,"to Wlk")
slidemove(Actor003,{1.113, 0, -17.951},2.6,2.6)
wait_time(2.8)
turn_lookat(Actor004,Actor001,0.4)
turn_lookat(Actor003,Actor001,0.4)
wait_time(0.4)
PlayActionDirect(Actor004,"to Std_Loop")
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
Appear(Actor002)
PlayActionDirect(Actor002,"to Wlk")
slidemove(Actor002,{1.72, 0, -17.31},2.6,2.6)
wait_time(2.6)
turn_lookat(Actor002,Actor001,0.4)
wait_time(0.4)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.4)
PlayActionDirect(Actor001,"to Wlk")
turn_lookat(Actor001,Actor003,0.4)
wait_time(0.4)
PlayActionDirect(Actor001,"to Std_Loop")
setup_small_camera_end(RndCamera003)
setup_small_camera_start()
wait_time(0.8)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ディナタン★★:あ、兄さん！<br>――と、ギネヴィアさんとエレインさん
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_009_0110012")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ディナタン★★:
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_009_0110013")

	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Sad")

	--★★エレイン★★:それは――…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","EA_009_0110014")

	change_face(Actor003,"Sad")

	--★★ギネヴィア★★:………
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_009_0110015")

	PlayAction(Actor004,"to  Std_Talk")

	--★★ノワール★★:…そんなことより<br>なにか用か、ディナタン
	Talk(Actor004,"CHRNAME_NOIR","speech","L","EA_009_0110016")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ディナタン★★:え？あぁ…用ってほどでもないけど
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_009_0110017")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ディナタン","0026")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ディナタン★★:ちょっと兄妹の親睦を深めようかな～と<br>ほら、降誕祭の感想とか聞いたりして
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_009_0110018")

	change_face(Actor004,"Sad")

	--★★ノワール★★:そうか…降誕祭…
	Talk(Actor004,"CHRNAME_NOIR","speech","L","EA_009_0110019")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ディナタン★★:兄さん？
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_009_0110020")

	PlayAction(Actor004,"to  Std_No")
	change_face(Actor004,"Normal")

	--★★ノワール★★:あ、いや――…
	Talk(Actor004,"CHRNAME_NOIR","speech","L","EA_009_0110021")

-- ▼直接出力
set_common_look_at(Actor003,Actor002)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Smile")

	--★★ギネヴィア★★:楽しかったわよ。ね、エレイン！
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_009_0110023")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("エレイン","0008")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エレイン★★:そ、そうですね！街がキラキラしてて<br>皆も、笑顔で――
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","EA_009_0110024")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0007")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ギネヴィア★★:ね！うん…たのしかった
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_009_0110025")

	change_face(Actor003,"Sad")

	--★★ギネヴィア★★:………
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_009_0110027")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ディナタン★★:…？<br>ギネヴィアさん、どうかしましたか
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_009_0110028")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★ギネヴィア★★:な、なんでもないわ
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_009_0110029")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ディナタン","0034")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ディナタン★★:でも、だって…顔色が…
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_009_0110030")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Angry")
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0017")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ギネヴィア★★:本当に、なんでもないったら…！
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_009_0110031")

	PlayAction(Actor001,"to  Std_Joy")
	change_face(Actor001,"Surprise")

	--★★ディナタン★★:！
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_009_0110033")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
	change_face(Actor003,"Sad")

	--★★ギネヴィア★★:あ…ご、ごめん…わたし
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_009_0110034")

	change_face(Actor002,"Sad")

	--★★エレイン★★:ギネヴィアさん…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","EA_009_0110035")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.2)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0021")
-- ▲直接出力
	change_face(Actor003,"Pain")

	--★★ギネヴィア★★:…わたし、もう行くから
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_009_0110036")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.4)
PlayActionDirect(Actor003,"to Wlk")
turn_chara(Actor003,81,0.6)
wait_time(0.6)
PlayActionDirect(Actor003,"to Run")
slidemove(Actor003,{9.34, 0, -16.8},2.8,1.0)
wait_time(0.8)
PlayActionDirect(Actor004,"to Wlk")
turn_chara(Actor004,66,0.4)
wait_time(0.4)
PlayActionDirect(Actor004,"to Std_Loop")
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,87,0.4)
wait_time(0.4)
PlayActionDirect(Actor001,"to Std_Loop")
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,87,0.4)
wait_time(0.5)
PlayActionDirect(Actor002,"to Std_Loop")
Hide(Actor003)
wait_time(0.8)
setup_small_camera_end()
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
	PlayAction(Actor004,"to  Std_No")
	change_face(Actor004,"Serious")

	--★★ノワール★★:ギネヴィア！！
	Talk(Actor004,"CHRNAME_NOIR","speech","L","EA_009_0110038")

	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Surprise")

	--★★エレイン★★:
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","EA_009_0110039")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.4)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad01")
	change_face(Actor001,"Sad")

	--★★ディナタン★★:どうしよう<br>私、なにかへんなこと言っちゃったかな…
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_009_0110040")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start()
PlayActionDirect(Actor001,"to Wlk")
turn_lookat(Actor001,Actor004,0.4)
wait_time(0.4)
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(0.6)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ディナタン★★:…私、謝ってくる！
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_009_0110041")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor004,"to Wlk")
turn_lookat(Actor004,Actor001,0.6)
wait_time(0.6)
PlayActionDirect(Actor004,"to Std_Loop")
set_common_look_at(Actor004,Actor001)
PlayActionDirect(Actor002,"to Wlk")
turn_lookat(Actor002,Actor001,0.8)
wait_time(0.8)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(1.2)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
	change_face(Actor004,"Normal")

	--★★ノワール★★:
	Talk(Actor004,"CHRNAME_NOIR","speech","L","EA_009_0110042")

	PlayAction(Actor001,"to  Std_Angry")
-- ▼直接出力
PlayPartVoiceDirect("ディナタン","0028")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ディナタン★★:兄さん、なんで止めるの！？
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_009_0110043")

	open_select_window_tag(Actor004,"Normal","EA_009_0110045","EA_009_0110046")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
bgm_play("BGM_ADV_Painful2")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ノワール★★:………
	Talk(Actor004,"CHRNAME_NOIR","speech","L","EA_009_0110049")

	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
PlayPartVoiceDirect("ディナタン","0019")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ディナタン★★:
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_009_0110050")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
	change_face(Actor004,"Sad")

	--★★ノワール★★:ごめん…でも言えないんだ<br>俺もまだ、気持ちの整理がついてなくて
	Talk(Actor004,"CHRNAME_NOIR","speech","L","EA_009_0110051")

	change_face(Actor002,"Sad")

	--★★エレイン★★:先輩…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","EA_009_0110052")

	PlayAction(Actor004,"to  Std_Talk")
	change_face(Actor004,"Normal")

	--★★ノワール★★:
	Talk(Actor004,"CHRNAME_NOIR","speech","L","EA_009_0110053")

	change_face(Actor001,"Sad")

	--★★ディナタン★★:兄さん…
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_009_0110054")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
bgm_play("BGM_ADV_Painful2")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ノワール★★:なにも知らないお前が行っても<br>ギネヴィアを傷つけるだけだ
	Talk(Actor004,"CHRNAME_NOIR","speech","L","EA_009_0110057")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Sad")

	--★★ノワール★★:だから、行かないでほしい
	Talk(Actor004,"CHRNAME_NOIR","speech","L","EA_009_0110058")

	change_face(Actor002,"Sad")

	--★★エレイン★★:先輩…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","EA_009_0110059")

	PlayAction(Actor001,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoiceDirect("ディナタン","0015")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ディナタン★★:なにそれ…全然わかんないよ
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_009_0110060")

	change_face(Actor001,"Sad")

	--★★ディナタン★★:
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_009_0110061")

	change_face(Actor004,"Sad")

	--★★ノワール★★:………
	Talk(Actor004,"CHRNAME_NOIR","speech","L","EA_009_0110062")

	change_face(Actor001,"Anger")

	--★★ディナタン★★:…言ってくれないんだ
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_009_0110063")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
	change_face(Actor004,"Sad")

	--★★ノワール★★:
	Talk(Actor004,"CHRNAME_NOIR","speech","L","EA_009_0110064")

	goto Block1end

::Block1end::
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Sad")

	--★★ディナタン★★:…兄さん、いいの？<br>ギネヴィアさんを追わなくて
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_009_0110067")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ノワール★★:………
	Talk(Actor004,"CHRNAME_NOIR","speech","L","EA_009_0110068")


	--★★ディナタン★★:私に行くなって言うなら<br>兄さんが追いかけなきゃ駄目だよ
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_009_0110069")

	PlayAction(Actor001,"to  Std_No")

	--★★ディナタン★★:
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_009_0110070")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0025")
-- ▲直接出力

	--★★ノワール★★:…わからないんだ<br>追いかけて、なんて言ったらいいのか
	Talk(Actor004,"CHRNAME_NOIR","speech","L","EA_009_0110071")


	--★★ディナタン★★:………
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_009_0110072")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Pain")

	--★★ノワール★★:…なんて、そんなの逃げてるだけだよな<br>わかってる。わかってるんだけど…
	Talk(Actor004,"CHRNAME_NOIR","speech","L","EA_009_0110073")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Sad")

	--★★エレイン★★:先輩…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","EA_009_0110074")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0008")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ノワール★★:…ギネヴィアと話をしてくる
	Talk(Actor004,"CHRNAME_NOIR","speech","L","EA_009_0110075")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
Hide(Actor004)
setup_small_camera_start(Camera001)
turn_chara(Actor001,87,0)
turn_chara(Actor002,87,0)
wait_time(0.8)
fadein(FADE_TIME)
wait_time(FADE_TIME)
wait_time(0.4)
-- ▲直接出力

	--★★ディナタン★★:
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_009_0110077")

-- ▼直接出力
PlayActionDirect(Actor001,"to  Std_Sad01")
SkipDefaultMotion(Actor001)
wait_time(1.5)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10102012)
preload_sound("BGM_ADV_Painful2")
	InitializeLoad_Preload()
	load_area_scene_preload(115119)
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101030","002","101030002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401005","001","401005001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
