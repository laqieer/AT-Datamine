-- このluaスクリプトは、MA_01A112_04.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",90,CharaPos110901_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_002)
	Camera002 = SetTemplate("Actor002",-90,CharaPos110901_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_006)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110901)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "挨拶")
-- ▲直接出力

	--★★ギネヴィア★★:ご機嫌は？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_040002")

	open_select_window_tag(Actor001,"Normal","MA_01A112_040004","MA_01A112_040005","MA_01A112_040006")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:おかげさまで。君は？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_040008")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:お互い片肺でしょ<br>見栄張らないの
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_040009")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:ま…キラーズのわたしはね<br>戦うためにできてるから
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_040010")

	PlayAction(Actor002,"to Finger")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:でもその調子で気にかけてくれると<br>わたし、喜ぶよ？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_040012")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:エレインに感謝しないと
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_040014")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:…エレイン、彼女がいなかったら<br>わたしダメになってた
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_040015")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:エレインの面会ができるようになったら<br>お礼…言う。言わなきゃ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_040016")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "苦しみ")
-- ▲直接出力
	change_face(Actor001,"Pain")

	--★★ノワール★★:実は…まだ少し痛みがあるんだ<br>………いたたっ！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_040018")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:え！？ちょ、ちょっと大丈夫なの！？<br>すぐ療養院に――
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_040020")

-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:うそうそ。冗談だよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_040022")

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ギネヴィア★★:…はあ！？なにそれ！<br>言っていい冗談と悪い冗談があるでしょ！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_040023")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:ご、ごめん…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_040024")

	goto Block1end

::Block1end::
-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
set_rot(Actor001,{0,70,0})
set_animationcontroller(Actor002,"Com_f_SitController","to Sit01_Loop")
Camera002=setup_small_camera_resetting(Actor002,CharaPos001,CameraPos001)
set_rot(Actor002,{0,105,0})
lookat_weight(Actor001,0.6,0.03,0.7,0)
lookat_weight(Actor002,0,0,0,0)
setup_small_camera_start()
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:…それでね、あのね<br>手紙を出したいの、わたし
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_040026")

	change_face(Actor001,"Normal")

	--★★ノワール★★:手紙？エレインとの文通の？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_040027")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:それは…お返事待ち<br>ずっと返ってきてないの
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_040028")


	--★★ギネヴィア★★:何通もね、送っちゃって<br>むしろ迷惑だったかなあ…なんて、あはは
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_040029")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:…きっと元気づけられてるよ。エレインも
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_040030")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
change_face(Actor001,"Normal")
-- ▲直接出力

	--★★ギネヴィア★★:うん…でね、今出そうとしてるのは…<br>エクセリアとリリアーナへの…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_040031")


	--★★ギネヴィア★★:…直接お話しなきゃとは思うの<br>だけど言葉が出てこない気もするの
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_040033")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ギネヴィア★★:だから手紙に書いて…<br>わ、渡しに、行かなきゃ、って…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_040034")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01A112_040035","MA_01A112_040036")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:それなら俺もいっしょに行くよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_040038")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:…わたし卑怯だね。ちょっと
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_040039")

-- ▼直接出力
lookat_delay_weight(Actor002,0.5,0.03,0.7,0,1)
 --PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:でも…ありがと。本当に
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_040040")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:行ってらっしゃい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_040042")

-- ▼直接出力
lookat_delay_weight(Actor002,0.5,0.03,0.7,0,1)
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:…あの、ね？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_040044")

	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:………ついてきてよ<br>怖いの、すごく怖いの
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_040045")

	goto Block2end

::Block2end::
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110901)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
