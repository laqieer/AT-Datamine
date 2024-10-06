-- このluaスクリプトは、CO_101028_0602.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_01","110111_01_h")
Include("content_adv_advsmall_110111_01","Template110111_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110111_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_002)
	InitializeTemplateRandomCamera110111_01()
	InitializeTemplate110111_01()
-- ▼直接出力
turn_lookat(Actor001,Actor002,0)
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor002,Actor001,0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110111)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ガラハッド", "苦しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:プリンセス・バトルロードを通して<br>痛感しているんだ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_06020002")

	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:どうした、ノワール？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_06020086")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Surprise")

	--★★ノワール★★:いや、なんでもない…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_06020087")

	change_face(Actor002,"Normal")

	--★★ガラハッド★★:そうか？<br>…あのな
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_06020088")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:やはり、ガラハッドが女の子らしく<br>振る舞うなんて無理なんじゃないかと思う
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_06020003")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101028_06020005","CO_101028_06020006")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ひょっとして付き合ってる俺に<br>迷惑をかけてるとか思ってないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_06020008")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Smile")

	--★★ノワール★★:俺は結構楽しませてもらってるし<br>女の子らしくなったキミも見てみたい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_06020009")

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:続けたらいいじゃないか<br>フィエナのためにもさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_06020010")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガラハッド", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガラハッド★★:ありがとう<br>ノワールは優しいな
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_06020011")

	change_face(Actor002,"Sad")

	--★★ガラハッド★★:だが…<br>どうしてもあと一歩が踏み出せないんだ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_06020012")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:女の子らしく<br>振る舞えてきてると思うけどな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_06020014")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ガラハッド", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:そうだろうか…<br>いや、これがよくないのかもしれない
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_06020015")

	change_face(Actor002,"Sad")

	--★★ガラハッド★★:ノワールや姉上の言葉を<br>素直に受け入れられない、この姿勢が
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_06020016")

	goto Block1end

::Block1end::
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:そもそも、どうしてガラハッドは<br>フィエナのレッスンに付き合っているんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_06020018")

-- ▼直接出力
PlayPartVoice("ガラハッド", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:これは恩返し…<br>いや、罪滅ぼしというのが正しいだろうか
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_06020020")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:恩返し？罪滅ぼし？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_06020021")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ガラハッド★★:少し長くなるが<br>聞いてもらえるか？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_06020022")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ああ、もちろん
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_06020023")


	--★★ガラハッド★★:どこかで話したかもしれないが僕には家族がいない
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_06020024")


	--★★ガラハッド★★:バルバロイに母を殺され
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_06020025")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ガラハッド★★:ひとりで泣いているところをコルベニック城のみんなに保護された
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_06020026")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガラハッド", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガラハッド★★:コルベニック城のみんなは僕を快く受け入れてくれた
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_06020029")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ガラハッド★★:なかでも姉上は僕に特別優しくしてくれた
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_06020030")

	change_face(Actor002,"Normal")

	--★★ガラハッド★★:いつもそばにいてくれて服やおもちゃをたくさんプレゼントしてくれた
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_06020031")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:でも僕はそんな想いを無下にした姉上を拒絶したんだ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_06020032")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:フィエナを拒絶していた？…どうして？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_06020033")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガラハッド", "悩む")
-- ▲直接出力

	--★★ガラハッド★★:ひとりぼっちになり生きる目的すら見失った僕に優しくする理由がわからなかったからだ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_06020034")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ガラハッド★★:優しい顔の裏で僕を嘲笑っているのではないかとすら思った
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_06020035")

	open_select_window_tag(Actor001,"Normal","CO_101028_06020037","CO_101028_06020038")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:キミの過去にそんなことがあったのか大変だったんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_06020040")

	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:当時の僕は神様を呪ったよ「なぜこんな目に遭わせるのか」と
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_06020041")

-- ▼直接出力
PlayPartVoice("ガラハッド", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:でも、そんな僕を<br>姉上が救ってくれたんだ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_06020042")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:フィエナはそんな…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_06020044")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガラハッド", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:そうだ、ノワール姉上はそんな人じゃない
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_06020045")

	change_face(Actor002,"Normal")

	--★★ガラハッド★★:僕はそれをよく知っているんだ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_06020046")

	goto Block2end

::Block2end::
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:僕がどれだけ心にカギをかけても姉上はそれをこじあけてきた
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_06020048")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ガラハッド★★:そしてこう言ったんだ<br>「私、きょうだいが欲しかったんだ」って
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_06020049")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ガラハッド", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガラハッド★★:あまりにあっけらかんと言うものだからそのときは思わず吹き出してしまったよ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_06020051")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:でも、おかげで心がすっと軽くなった
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_06020052")


	--★★ガラハッド★★:吹きだした僕を見た姉上は嬉しそうに笑ってそれまで以上に優しく接してくれた
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_06020053")


	--★★ガラハッド★★:お爺様の前に僕を連れて行って「妹ができたの！」と紹介してくれたときの
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_06020054")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ガラハッド", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガラハッド★★:ふたりのあたたかな微笑みは今でも忘れられない
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_06020055")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:そんな優しい姉上を僕はまたキズつけてしまった
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_06020056")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ガラハッド", "苦しみ")
-- ▲直接出力

	--★★ガラハッド★★:僕がワガママに騎士道を押し付けたせいで姉上に嫌われてしまった
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_06020057")

	open_select_window_tag(Actor001,"Normal","CO_101028_06020059","CO_101028_06020060","CO_101028_06020061")
	if is_select(1) then
		goto Block3_1
	elseif is_select(2) then
		goto Block3_2
	elseif is_select(3) then
		goto Block3_3
	end

::Block3_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:騎士道と女の子らしさは両立できるさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_06020063")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:ガラハッドにはその自信がないレッスンもうまくいかなかった
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_06020064")

	change_face(Actor001,"Normal")

	--★★ノワール★★:たった一度の失敗で諦めるのか？キミの騎士道はそんなものなのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_06020065")

	change_face(Actor002,"Sad")

	--★★ガラハッド★★:僕の騎士道…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_06020066")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガラハッド", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:そうだな、こんなことで諦めたらつまらない騎士道で終わってしまう
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_06020067")

	goto Block3end

::Block3_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:たった数回のケンカで…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_06020069")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:いや、ケンカにも満たないただの言い合いで家族の絆は壊れやしないよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_06020070")

	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:むしろケンカを重ねて強くなっていくものさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_06020071")

	change_face(Actor001,"Normal")

	--★★ノワール★★:予想していなかったことに驚いたかもしれないがフィエナはキミを嫌いになってなんかいない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_06020072")

	change_face(Actor001,"Smile")

	--★★ノワール★★:むしろ本音をぶつけてくれたことを喜んでいるんじゃないかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_06020073")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ガラハッド", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:ノワール…！そういうものだろうか
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_06020074")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ああ、そういうものだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_06020075")

	goto Block3end

::Block3_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ふたりのあいだにそんなことがあったのか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_06020077")

	change_face(Actor001,"Sad")

	--★★ノワール★★:フィエナ、悲しかったろうな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_06020078")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Pain")

	--★★ガラハッド★★:何度も何度も同じ過ちを繰り返す…僕はなんて愚かなんだ…！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_06020079")

	goto Block3end

::Block3end::
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:でも、もしも本当に辛いのならレッスンを続けなくてもいいと思う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_06020081")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:フィエナだって無理強いはしないはずあとはガラハッドがどうしたいかだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_06020082")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:僕は…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_06020083")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:まだ、わからない少し考えさせてくれ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_06020085")

-- ▼直接出力
local trustParam = set_communication_rankup("ガラハッド_コミュランク", "ガラハッド_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
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
	load_area_scene_preload(110111)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
