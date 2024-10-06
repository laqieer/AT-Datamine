-- このluaスクリプトは、CO_101037_0402.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_01","110191_01_h")
Include("content_adv_advsmall_110191_01","Template110191_01_h")
Include("content_adv_advsmall_110191_01","110191_01_h")
Include("content_adv_advsmall_110191_01","Template110191_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_525_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110191_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_019_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_004)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110191_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_514_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_005)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110191_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_513_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_006)
	InitializeTemplateRandomCamera110191_01()
	InitializeTemplate110191_01()
-- ▼直接出力
Hide(Actor003)
Hide(Actor004)
Hide(Actor005)
-- ▲直接出力
end
function template2()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_007)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_525_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110191_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_019_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_004)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110191_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_514_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_005)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110191_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_513_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_006)
	InitializeTemplateRandomCamera110191_01()
	InitializeTemplate110191_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110191)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101037","001","101037001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101052","001","101052001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101039","001","101039001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101038","001","101038001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラシア★★:うーん、いませんね
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_04020002")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:どこかで<br>行き違いになっちゃったのかもな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_04020003")

	change_face(Actor002,"Surprise")

	--★★ラシア★★:…あ
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_04020004")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
Appear(Actor004)
Appear(Actor005)
Appear(Actor003)
keep_ik_lookat(Actor002,Actor003,"J_Head")
template2()
setup_small_camera_start()
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
setup_small_camera_start(Camera002)
PlayPartVoice("ラシア", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラシア★★:ヴェルナルス様！フレン！ローラ！
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_04020006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to Greet_one")
-- ▼直接出力
PlayPartVoice("フレン", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★フレン★★:ラシア～！
	Talk(Actor004,"CHRNAME_FREN","speech","L","CO_101037_04020008")

-- ▼直接出力
PlayPartVoice("ラシア", "笑い")
-- ▲直接出力

	--★★ラシア★★:なんの話をしてたの？
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_04020010")

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ローラ", "笑い")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★ローラ★★:ヴェルナルス先生の<br>教師ぶりについて、かな…？
	Talk(Actor005,"CHRNAME_LOLA","speech","L","CO_101037_04020011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("フレン", "肯定2")
-- ▲直接出力

	--★★フレン★★:ヴェルナルス先生の授業ってさ<br>すっごくわかりやすいよね？
	Talk(Actor004,"CHRNAME_FREN","speech","L","CO_101037_04020012")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "肯定3")
-- ▲直接出力

	--★★ラシア★★:あ、うん
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_04020013")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ラシア★★:ヴェルナルス様の教えかたは<br>的確というか実践的というか！
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_04020014")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ヴェルナルス", "挨拶")
-- ▲直接出力

	--★★ヴェルナルス★★:…言ったはずだラシア<br>校内では「先生」と呼ぶように、と
	Talk(Actor003,"CHRNAME_VERNARTH","speech","L","CO_101037_04020016")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ラシア", "苦しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラシア★★:すっ、すみません！つい！
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_04020018")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)

	--★★ヴェルナルス★★:…いや、頭は下げなくてもいい
	Talk(Actor003,"CHRNAME_VERNARTH","speech","L","CO_101037_04020019")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "否定")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラシア★★:いえっ！<br>礼儀はちゃんとしないと
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_04020020")


	--★★ラシア★★:ヴェルナ叔父様も<br>いつもそう言ってるじゃないですか！
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_04020021")

	play_head_motion(Actor005, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ローラ", "挨拶")
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★ローラ★★:あの…ラシア…
	Talk(Actor005,"CHRNAME_LOLA","speech","L","CO_101037_04020023")

	change_face(Actor004,"Surprise")

	--★★フレン★★:むしろエスカレートしちゃったよ？
	Talk(Actor004,"CHRNAME_FREN","speech","L","CO_101037_04020024")

-- ▼直接出力
PlayPartVoice("ラシア", "驚き")
-- ▲直接出力

	--★★ラシア★★:え？なにが？
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_04020026")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("フレン", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★フレン★★:「叔父様」って言っちゃってる
	Talk(Actor004,"CHRNAME_FREN","speech","L","CO_101037_04020027")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ラシア", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ラシア★★:ああっ！先生って呼ばなきゃなのに！
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_04020028")

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ローラ", "笑い")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★ローラ★★:大丈夫、聞かなかったことにするから<br>…ね、先生？
	Talk(Actor005,"CHRNAME_LOLA","speech","L","CO_101037_04020030")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フレン", "肯定2")
-- ▲直接出力

	--★★フレン★★:そうそう、ラシアはなにも言ってないよ！<br>ノワールも聞いてないよね？
	Talk(Actor004,"CHRNAME_FREN","speech","L","CO_101037_04020031")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101037_04020033","CO_101037_04020034","CO_101037_04020035")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:いや、しっかり聞いちゃったけど<br>ヴェルナ叔父様って言ってるの
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_04020037")

	PlayAction(Actor004,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("フレン", "怒り")
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★フレン★★:ノ・ワ・－・ルゥ～～～…！？
	Talk(Actor004,"CHRNAME_FREN","speech","L","CO_101037_04020038")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ラシア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラシア★★:やっぱり<br>みんなに聞かれてたんだぁ…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_04020039")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:え？あ、ああ<br>聞いてないよ。俺はなにも
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_04020041")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ラシア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラシア★★:なのに<br>なんで笑ってるんですか？
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_04020042")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:これはその…<br>４人のやりとりが微笑ましくてさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_04020043")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ごめん、まったく聞いてなかった<br>別のことを考えててさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_04020045")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ラシア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラシア★★:たしかに<br>聞いてほしくはなかったんですけど…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_04020046")

-- ▼直接出力
PlayPartVoice("ローラ", "悩む")
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★ローラ★★:この場にいながら<br>別のことを考えていたの…？
	Talk(Actor005,"CHRNAME_LOLA","speech","L","CO_101037_04020047")

	goto Block1end

::Block1end::
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フレン", "悩む")
-- ▲直接出力
	change_face(Actor004,"Laugh")

	--★★フレン★★:…さて、私たちはそろそろ行こうか
	Talk(Actor004,"CHRNAME_FREN","speech","L","CO_101037_04020049")

-- ▼直接出力
if is_active(RndCamera090) == false then
DontChangeRandomCamera(true)
on_camera(Camera005)
end
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ローラ", "笑い")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★ローラ★★:うん、お姉ちゃん
	Talk(Actor005,"CHRNAME_LOLA","speech","L","CO_101037_04020050")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
Hide(Actor005)
Hide(Actor004)
wait_time(CHARA_IN_WAIT)
setup_small_camera_start()
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ラシア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ラシア★★:うう…恥ずかしい…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_04020052")


	--★★ラシア★★:私ってばどうしてこうも<br>おっちょこちょいなんでしょうか…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_04020053")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ヴェルナルス", "肯定")
-- ▲直接出力

	--★★ヴェルナルス★★:人は失敗を繰り返し成長していく<br>失敗を恥じる必要はない
	Talk(Actor003,"CHRNAME_VERNARTH","speech","L","CO_101037_04020054")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★ヴェルナルス★★:同じ失敗を繰り返さないという意識を持つこと<br>それを忘れなければよいのだ
	Talk(Actor003,"CHRNAME_VERNARTH","speech","L","CO_101037_04020055")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ラシア★★:は、はい…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_04020056")


	--★★ヴェルナルス★★:それにしても<br>学園生活が楽しそうでなによりだ
	Talk(Actor003,"CHRNAME_VERNARTH","speech","L","CO_101037_04020058")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ラシア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラシア★★:はい！
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_04020059")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:あ、ヴェルナルス先生
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_04020061")

-- ▼直接出力
PlayPartVoice("ヴェルナルス", "肯定")
-- ▲直接出力

	--★★ヴェルナルス★★:なんだ？
	Talk(Actor003,"CHRNAME_VERNARTH","speech","L","CO_101037_04020062")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:ほら、ラシア<br>本来の目的を果たさないと
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_04020063")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
keep_ik_lookat(Actor002,Actor003,"J_Head")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラシア★★:そうでした！<br>モルガン先生が呼んでるそうです
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_04020064")

-- ▼直接出力
if is_active(RndCamera090) == false then
DontChangeRandomCamera(true)
on_camera(Camera003)
end
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ヴェルナルス", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ヴェルナルス★★:…そんな時間か、礼を言う
	Talk(Actor003,"CHRNAME_VERNARTH","speech","L","CO_101037_04020065")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
Hide(Actor003)
turn(Actor002,0,220,0,0.1)
wait_time(CHARA_IN_WAIT)
setup_small_camera_start()
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:なあ、今ヴェルナルス先生、<br>ちょっと笑ってなかったか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_04020067")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:ていうか、多少なりとも<br>感情を表に出しているところを初めて見たかも
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_04020068")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ラシア", "驚き")
-- ▲直接出力

	--★★ラシア★★:そうですか？
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_04020069")

	open_select_window_tag(Actor001,"Normal","CO_101037_04020071","CO_101037_04020072")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:呆れてる顔とか、するんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_04020074")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラシア★★:呆れてましたよね…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_04020075")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:でも、怒っていたわけじゃなくて<br>すごく優しい表情だったよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_04020076")

	change_face(Actor002,"Sad")

	--★★ラシア★★:そう…でしょうか…？
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_04020077")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ラシアを見るときは<br>すごく優しい目をしてたな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_04020079")

	change_face(Actor002,"Surprise")

	--★★ラシア★★:そうでしたか？
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_04020080")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ああ、してたよ<br>先生でもあんな表情するんだなあ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_04020081")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ラシア", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラシア★★:近寄りがたいっていう人もいますけど<br>あたたかくて、お茶目で、ユーモアがあるんです
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_04020082")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:お、お茶目？ユーモア？<br>へえ、意外だな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_04020083")

	goto Block2end

::Block2end::
-- ▼直接出力
PlayPartVoice("ラシア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラシア★★:でも、先生もこのあいだのノワールと<br>同じことを言っていましたね
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_04020085")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:同じこと？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_04020086")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ラシア", "肯定")
-- ▲直接出力

	--★★ラシア★★:失敗は繰り返さなければいいって
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_04020087")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:あぁ、そういえば言ったことあったな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_04020088")

-- ▼直接出力
PlayPartVoice("ラシア", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ラシア★★:ノワール、もしも私がまた<br>なにか失敗しそうになったら…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_04020089")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力

	--★★ノワール★★:そのときは、しっかり注意させてもらうよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_04020090")

-- ▼直接出力
local trustParam = set_communication_acquired("ラシア_コミュランク", "ラシア_親密度")
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
	load_area_scene_preload(110191)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101037","001","101037001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101052","001","101052001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101039","001","101039001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101038","001","101038001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
