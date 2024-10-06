-- このluaスクリプトは、MA_01106_21.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110141_02","110141_02_h")
Include("content_adv_advsmall_110141_02","Template110141_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110141_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110141_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110141_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_03_SleepController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_001)
	InitializeTemplateRandomCamera110141_02()
	InitializeTemplate110141_02()
-- ▼直接出力
DontCameraOffset(Actor003)
--set_pos(Actor003,{4.28,0.78,1.46})
--set_rot(Actor003,{4,-90,0})
DontChangeRandomCamera(true)
-- ▲直接出力
-- ▼直接出力
setup_huton_110141_02()
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115144)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101017","003","101017003","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	change_face(Actor003,"Pain")

	--★★マルディサント★★:…？<br>ここは…
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_210002")

	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:マルディサント！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_210003")


	--★★ノワール★★:ここは学園だ、帰ってきたんだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_210004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)
	change_face(Actor003,"Anger")

	--★★マルディサント★★:こんなとこで寝てらんねえ…！<br>せんせを助けに、這ってでも──…！
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_210005")

	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Sad")

	--★★ディナタン★★:寝てなきゃダメだよ…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_210006")

	change_face(Actor003,"Sad")

	--★★マルディサント★★:なんで止めたんだよ…！
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_210007")

-- ▼直接出力
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor002)
DontChangeRandomCamera(true)
lookat_delay_weight_reset(Actor003 , 1)
set_enable_auto_lookat(Actor003, false)
Camera003 = setup_small_camera_resetting(Actor003,CharaPos009,CameraPos009)
set_animationcontroller(Actor003, "Chr_507_03_SitController", "to Sit01_Loop")
keep_ik_lookat(Actor003, Actor002, "J_Head")
lookat_delay_weight(Actor003,1.2,0.05,0.5,0,1.0)
off_active(huton)
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:え…？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_210008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★マルディサント★★:なんで止めたんだよ、あのとき！<br>あのオッサンがせんせを連れてったとき！
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_210009")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Sad")

	--★★ディナタン★★:だ、だって、あの──…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_210010")


	--★★マルディサント★★:育ててもらった恩があるから<br>見逃したんじゃねえのか…！？
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_210011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_No")

	--★★ディナタン★★:違うよ、マルディサント
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_210012")


	--★★マルディサント★★:なにが違ぇんだよ言ってみろよッ！！
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_210013")

	change_face(Actor002,"Anger")

	--★★ディナタン★★:あなたが心配だったから！！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_210014")

	change_face(Actor003,"Surprise")

	--★★マルディサント★★:ハ、ハァ？<br>アタシィ！？
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_210015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★マルディサント★★:…っ、あ、アタシ、アタシのことなんか<br>アンタにゃカンケーねえだろ！
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_210016")

	change_face(Actor002,"Sad")

	--★★ディナタン★★:あなたが、し、死んじゃったら<br>いやだって…思ったから…！だから…！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_210017")

	change_face(Actor003,"Sad")

	--★★マルディサント★★:こ、こんなことになるんならなぁ…！<br>アタシなんかあのとき死んでりゃ良かったんだ！
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_210018")

	PlayAction(Actor002,"to  Std_Angry")
	change_face(Actor002,"Anger")

	--★★ディナタン★★:あのときっていつよ！？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_210019")

	change_face(Actor003,"Anger")

	--★★マルディサント★★:妹が死んだときだよ！こないだみたいに<br>アタシ、なんっっもしてやれなかった…！
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_210020")

	change_face(Actor003,"Sad")

	--★★マルディサント★★:メシも、良い服も、家も、部屋も…！<br>全部モルガンせんせに与えてもらって…！
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_210021")

	change_face(Actor003,"Anger")

	--★★マルディサント★★:妹は狂忘症で、目を覚ますたびに<br>アタシのことわかんなくなるんだぜ！？
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_210022")

	change_face(Actor003,"Sad")

	--★★マルディサント★★:だからアタシ『良い姉ちゃんごっこ』してた…<br>安心して欲しくて、笑顔演じ続けて…
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_210023")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
lookat_delay_weight(Actor003,1.0,0.05,0.3,0,1.0)
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★マルディサント★★:やっっすい芝居してたよ！理想的な姉！<br>中身はカラっぽのままでアタシはなにも──…！
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_210024")

	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Sad")

	--★★ディナタン★★:そ、んな、こと…ないよ…っ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_210025")

-- ▼直接出力
lookat_delay_weight(Actor003,1.2,0.05,0.5,0,1.0)
-- ▲直接出力
	open_cutin(1,2)
	on_cutin(1,Actor003,"Anger")

	--★★マルディサント★★:<ruby=アイドル>偶像</ruby>に現実わかんのかぁ！？<br><ruby=フェアリー>妖精</ruby>にわかんのかよ！？
	Talk(Actor003,"CHRNAME_MALADISANT","speech","N","MA_01106_210026")

	open_cutin(2,2)
	on_cutin(1,Actor002,"Anger")
	on_cutin(2,Actor003,"Anger")

	--★★ディナタン★★:…<br>この、図書院俳優！！
	Talk(Actor002,"CHRNAME_DINATAN","speech","N","MA_01106_210028")

	on_cutin(1,Actor002,"Anger")
	on_cutin(2,Actor003,"Anger")

	--★★マルディサント★★:やんのか、オラァッ！？
	Talk(Actor003,"CHRNAME_MALADISANT","speech","N","MA_01106_210029")

	open_select_window_tag(Actor001,"Normal","MA_01106_210031","MA_01106_210032","MA_01106_210033")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_No")
	close_cutin()
	change_face(Actor001,"Surprise")

	--★★ノワール★★:やめろ、落ち着け、ディナタン！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_210035")

	change_face(Actor002,"Anger")

	--★★ディナタン★★:止めないで兄さん！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_210036")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ディナタン★★:私、言わなきゃ！<br>マルディサントに言いたいことあるの…！！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_210037")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_No")
	close_cutin()
	change_face(Actor001,"Surprise")

	--★★ノワール★★:お、おい！<br>落ち着けマルディサント！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_210039")

	change_face(Actor003,"Anger")

	--★★マルディサント★★:そいつが売ってきた喧嘩だろーがッッ！
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_210040")

	PlayAction(Actor003,"to  Std_No")
	change_face(Actor003,"Pain")

	--★★マルディサント★★:や！アタシが売った感もなくはねえが<br>ともかくそいつとの喧嘩なんだよ！
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_210041")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	close_cutin()
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_210043")

	change_face(Actor003,"Anger")

	--★★マルディサント★★:なに黙って見てんだアンタ！？
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_210044")

	change_face(Actor002,"Anger")

	--★★ディナタン★★:見てるだけなら<br>向こう行っててよ兄さん！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_210045")

	goto Block1end

::Block1end::
	change_face(Actor003,"Anger")

	--★★マルディサント★★:その良い子ヅラはがしてやるよ！！
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_210047")

	PlayAction(Actor002,"to  Std_Angry")
	change_face(Actor002,"Anger")

	--★★ディナタン★★:だって安心して欲しいから！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_210048")


	--★★マルディサント★★:アァッ！？
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_210049")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:ずっと母さん…虚勢張って、最期まで元気で<br>兄さんもずっと、痛いことあっても平気なフリで
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_210050")

	change_face(Actor002,"Anger")

	--★★ディナタン★★:あなたもずっとツッパってた…！<br>でも、たくさん話しかけてきてくれた…！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_210051")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ディナタン★★:だから私、物分かり良く笑顔でいられたら！<br>きっとみんな安心すると思ったの！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_210052")


	--★★ディナタン★★:心配かけない良い子でいられたら！<br>張りつめてる空気も和らぐかもって！！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_210053")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★マルディサント★★:アンタ…
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_210054")


	--★★ディナタン★★:母さんも、兄さんも、マルディサントも…<br>ブライアンさんも、みんな──…！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_210055")

	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Sad")

	--★★ディナタン★★:ウウッ、うっ、うううう…！<br>にこにこ、してて欲しいから…ぁぁ…！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_210057")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ディナタン★★:でも、でも…！どうしたらいいかなんて…！<br>もうわからなくて…！！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_210058")

	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Sad")

	--★★ディナタン★★:ずっとずっと<br>なにも、してあげられないまま──…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_210060")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115144)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101017","003","101017003","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110141_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
