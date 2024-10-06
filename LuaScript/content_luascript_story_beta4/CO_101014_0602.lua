-- このluaスクリプトは、CO_101014_0602.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110041_02","110041_02_h")
Include("content_adv_advsmall_110041_02","Template110041_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",105,CharaPos110041_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110041_02,CameraPos110041_02_001)
	Camera002 = SetTemplate("Actor002",40,CharaPos110041_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleName110041_02,CameraPos110041_02_002)
	InitializeTemplateRandomCamera110041_02()
	InitializeTemplate110041_02()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110041)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★トリスタン★★:少し前…イゾルデに言ったんだ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_06020002")

	PlayAction(Actor002,"to  Std_Talk")

	--★★トリスタン★★:ボクについてなにか思っていることがあるなら<br>はっきり言って欲しいって
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_06020003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:うん<br>それでイゾルデはなんて？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_06020004")


	--★★トリスタン★★:「そろそろ勇気を出してもいいのではなくて？<br>差し伸べられた手を取ってもいい頃でしょう」
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_06020005")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("トリスタン","0007")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★トリスタン★★:見抜かれてたんだよね、結局<br>ボクが臆病で中途半端なことをさ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_06020006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101014_06020008","CO_101014_06020009")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0009")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:臆病で中途半端か<br>たしかにそのとおりだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_06020011")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:他人と関わり合いになりたくないのかと思えば<br>進んで支援活動を行ったりしてるし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_06020012")

	change_face(Actor002,"Normal")

	--★★トリスタン★★:…キミ、なかなかいい性格してるよね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_06020013")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:お前は臆病でも中途半端でもない<br>優しいんだ。優しすぎるんだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_06020015")

	change_face(Actor002,"Surprise")

	--★★トリスタン★★:イゾルデみたいなこと言うね、キミ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_06020016")

-- ▼直接出力
PlayPartVoice("トリスタン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★トリスタン★★:正直さ。ボクだって<br>素直になれたら楽だろうなって思うことはあるよ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_06020017")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_06020018")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★トリスタン★★:なんでもない<br>ただのひとりごとだよ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_06020019")

	goto Block1end

::Block1end::
-- ▼直接出力
CloseTalkWindow()
wait_time(1)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★トリスタン★★:…教えてほしいんだ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_06020021")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_06020022")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("トリスタン", "挨拶")
-- ▲直接出力

	--★★トリスタン★★:誰かの手を取るってことは<br>その人と信じあうってことでしょ？
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_06020023")

	PlayAction(Actor002,"to  Std_Talk")

	--★★トリスタン★★:信じた人に裏切られたときって<br>どうすればいいの？
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_06020024")


	--★★トリスタン★★:ボクを信じてくれた人の気持ちに<br>応えられなかったときはどうすれば？
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_06020025")

	change_face(Actor002,"Sad")

	--★★トリスタン★★:わからないなら<br>手なんか取らないほうがいいよね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_06020026")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★トリスタン★★:それすれば、誰も傷を負わずに済むもの
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_06020027")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:トリスタン…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_06020028")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor001,"to  Std_Worry")
wait_time(2)
-- ▲直接出力

	--★★ノワール★★:昔、お前の身に起こったこと<br>よければ聞かせてくれないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_06020030")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("トリスタン", "落胆")
-- ▲直接出力

	--★★トリスタン★★:イゾルデからなにか聞いたの？<br>まったく…
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_06020031")

-- ▼直接出力
CloseTalkWindow()
wait_time(2.5)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★トリスタン★★:ボク、コーンウォールの近くにあった<br>小さな国の王族の生まれなんだ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_06020033")

	PlayAction(Actor002,"to  Std_Talk")

	--★★トリスタン★★:その国には世にも珍しい宝が<br>隠されているというウワサがあってね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_06020034")


	--★★トリスタン★★:ボクはそんなのマユツバだと思ってたけど<br>信じたバカな連中もいた
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_06020035")

-- ▼直接出力
wait_time(0.5)
PlayPartVoiceDirect("トリスタン","0043")
-- ▲直接出力
	change_face(Actor002,"Pain")

	--★★トリスタン★★:ボクの親族もそのひとりだった
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_06020036")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:え…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_06020038")

	change_face(Actor002,"Serious")

	--★★トリスタン★★:ボクはバカな連中と<br>お宝を狙う盗賊とのいざこざに巻き込まれた
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_06020039")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★トリスタン★★:それで、逃げようとしたときに<br>親族のひとりが盗賊に囲まれているのが見えてさ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_06020040")


	--★★トリスタン★★:助けなきゃ<br>一緒に逃げなきゃと手を差し伸べたら
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_06020041")


	--★★トリスタン★★:その手を払われて、捕まえられた
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_06020042")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★トリスタン★★:親族が盗賊に囲まれて<br>危険な目にあわされそうだと勘違いしたんだよね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_06020043")

	change_face(Actor002,"Pain")

	--★★トリスタン★★:実際はその親族が盗賊と内通して<br>ボクをさらおうとしていたのにさ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_06020044")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★トリスタン★★:あのときのあいつの醜悪な顔は<br>今も脳裏から消えないよ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_06020045")

	open_select_window_tag(Actor001,"Normal","CO_101014_06020047","CO_101014_06020048")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	change_face(Actor001,"Sad")

	--★★ノワール★★:その…月並みなことしか言えないけど<br>大変だったな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_06020050")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Serious")

	--★★トリスタン★★:月並みな答えだけど、大変だったよ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_06020051")

	change_face(Actor002,"Serious")

	--★★トリスタン★★:人間の醜さを<br>まざまざと見せつけられた
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_06020053")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("ノワール", "怒り")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ノワール★★:なんて奴だ！<br>身内を売るだなんて…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_06020055")

	change_face(Actor002,"Serious")

	--★★トリスタン★★:まあ、人間誰しも欲に駆られたら<br>自分のことしか頭になくなるってことだね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_06020056")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Serious")

	--★★トリスタン★★:それが知れただけでもいい勉強になったよ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_06020057")

-- ▼直接出力
voice_play("VO_101009_sp_0006_3")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:トリスタン…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_06020058")

	goto Block2end

::Block2end::
	change_face(Actor002,"Serious")

	--★★トリスタン★★:身近な人間に裏切られるなんて<br>想像もしてなかったよ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_06020060")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★トリスタン★★:あの頃のボクはまだ純真無垢だったからね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_06020061")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:だから怖くなってしまったわけか<br>人を信じることが
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_06020062")

	change_face(Actor002,"Normal")

	--★★トリスタン★★:いまだにあの事件のことを<br>引きずってるってわけでもないよ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_06020063")

	PlayAction(Actor002,"to  Std_Talk")

	--★★トリスタン★★:もう昔のことだし<br>そういうことも起こりうるって理解してる
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_06020064")


	--★★トリスタン★★:だけど、じゃあ簡単に他人を信じたり<br>頼ったりできるかって言われたら、答えはノー
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_06020066")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★トリスタン★★:知らない人間は警戒してしかるべきだし<br>見知ったあとも必要以上に信じることはできない
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_06020067")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★トリスタン★★:ボクが信じられるのは<br>イゾルデただひとりさ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_06020068")

	change_face(Actor001,"Normal")

	--★★ノワール★★:だけどお前は<br>誰かのためを思っての行動をし続けてる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_06020069")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:それは誰かを信じてるとか<br>信じたいという思いからの行動じゃないのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_06020070")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor002,"to  Std_Worry")
wait_time(2)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("トリスタン", "悩む")
-- ▲直接出力

	--★★トリスタン★★:…そうだね<br>そこが中途半端で、矛盾してるよね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_06020072")

	change_face(Actor001,"Sad")

	--★★ノワール★★:トリスタン…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_06020073")


	--★★トリスタン★★:手を差し伸ばしても払われるなら<br>差し伸ばす前になにかできないだろうか
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_06020074")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★トリスタン★★:そう考えたんだけどさ<br>心が拒むんだよ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_06020075")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:だったら俺を…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_06020077")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("トリスタン","0017")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:ストップ<br>さっき言ったでしょ？
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_06020079")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★トリスタン★★:「簡単に他人を信じたり<br>頼ったりできるかって言われたら、答えはノー」
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_06020080")

	change_face(Actor002,"Sad")

	--★★トリスタン★★:今のボクにはまだ無理だよ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_06020081")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.5)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("トリスタン","0007")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:…ボクの話はここまで<br>キミといると、どうにも調子が狂うね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_06020082")


	--★★トリスタン★★:話すつもりのないことまで話しちゃったよ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_06020083")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("トリスタン","0006")
-- ▲直接出力

	--★★トリスタン★★:気分転換でもして帰ろうかな<br>じゃね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_06020084")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
local trustParam = set_communication_rankup("トリスタン_コミュランク", "トリスタン_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
 --open_trust_gauge(Actor002, trustParam)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110041)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110041_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
