-- このluaスクリプトは、CO_101028_1002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111016_03","111016_03_h")
Include("content_adv_advsmall_111016_03","Template111016_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111016_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName111016_03,CameraPos111016_03_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111016_03_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName111016_03,CameraPos111016_03_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPos111016_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_516_01_StdController","to Std_Loop",CameraAssetBundleName111016_03,CameraPos111016_03_002)
	InitializeTemplateRandomCamera111016_03()
	InitializeTemplate111016_03()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_ik_lookat(Actor001,Actor003,"J_Head")
lookat_weight(Actor001,0.3,0.1,0.65,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor003,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111016)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101036","001","101036001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フィエナ", "肯定")
-- ▲直接出力

	--★★フィエナ★★:よくぞ参った、諸君！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_10020002")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:やれやれ<br>いいから早く結果を聞かせてくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_10020003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("フィエナ", "怒り")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★フィエナ★★:ノワールってばせっかちさんだなあ<br>もうちょっと雰囲気を楽しもうよ
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_10020004")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★フィエナ★★:こほん！<br>さて、最終試験の結果だけど…
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_10020005")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",0.4)
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★ガラハッド★★:――その必要はありません、姉上
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_10020007")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ガラハッド？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_10020008")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガラハッド", "肯定3")
-- ▲直接出力

	--★★ガラハッド★★:試験の真っ最中だというのに<br>ガラハッドはルールを破ってしまいました
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_10020009")


	--★★ガラハッド★★:騎士として戦ったことに後悔はありませんが<br>女の子らしさを問う試験においては失格
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_10020010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:しかも、ノワールからもらったアクセサリーを<br>壊してしまうほどの大立ち回りです…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_10020011")


	--★★ガラハッド★★:この体たらく…<br>甘んじて不合格を受け入れる所存です
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_10020012")

-- ▼直接出力
PlayPartVoice("ガラハッド", "苦しみ")
-- ▲直接出力
	change_face(Actor002,"Pain")

	--★★ガラハッド★★:姉上から絶縁されることも覚悟のうえです
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_10020013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",0.1)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("フィエナ", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★フィエナ★★:え？絶縁？<br>誰が？誰のことを？
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_10020014")

	PlayAction(Actor002,"to  Std_Sad01")

	--★★ガラハッド★★:姉上がガラハッドを、です<br>ドレスのときのように姉上を悲しませてしまった
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_10020015")


	--★★フィエナ★★:ふええ？<br>私が、悲しんでる～？
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_10020016")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フィエナ", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★フィエナ★★:あははっ！<br>そんなわけないじゃない
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_10020018")

-- ▼直接出力
PlayPartVoice("ガラハッド", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:え？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_10020019")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フィエナ", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★フィエナ★★:最終試験なんかより困っている人を助けてあげなきゃ
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_10020020")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",0.4)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:姉上、しかし…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_10020021")

-- ▼直接出力
PlayPartVoice("フィエナ", "怒り")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★フィエナ★★:ガラハッドは騎士なんだから！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_10020022")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガラハッド", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:…はい！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_10020023")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",0.1)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("フィエナ", "挨拶")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★フィエナ★★:ノワールだってアクセサリーのこと気にしてないでしょ？
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_10020024")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101028_10020026","CO_101028_10020027")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",0.4)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:気にしてるよ結構高かったし、あれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_10020029")

-- ▼直接出力
PlayPartVoice("フィエナ", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★フィエナ★★:ノ・ワ・ー・ル・く・ん？
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_10020031")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Surprise")

	--★★ノワール★★:う、ウソウソ！まったくぜんぜんこれっぽっちも気にしてないよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_10020032")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",0.4)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:気にするわけないだろまたいつでもプレゼントするよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_10020034")

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("フィエナ", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★フィエナ★★:だって！気にせず何度でも失くして大丈夫だね！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_10020035")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:そこまでは言ってない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_10020036")

	goto Block1end

::Block1end::
-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",0.4)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Normal")

	--★★フィエナ★★:それよりノワールとのデート、楽しかった？
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_10020038")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",0.8)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ガラハッド", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ガラハッド★★:た、楽しかった…です
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_10020040")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",0.1)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フィエナ", "肯定")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★フィエナ★★:それなら最終試験は合格だよ！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_10020042")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ガラハッド", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:え…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_10020044")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("フィエナ", "悲しみ")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★フィエナ★★:私はね、ずっと心配だったの
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_10020045")

	change_face(Actor003,"Normal")

	--★★フィエナ★★:ガラハッドはいつも自分を押し殺して私やみんなのために戦ってくれているでしょ
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_10020046")


	--★★フィエナ★★:私のお願い、ゼッタイに聞いてくれるでしょ
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_10020047")

	PlayAction(Actor003,"to  Std_Sad02")
	change_face(Actor003,"Sad")

	--★★フィエナ★★:いつも思ってたんだいつか息が詰まっちゃうんじゃないかって
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_10020049")

-- ▼直接出力
PlayPartVoice("フィエナ", "照れ")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★フィエナ★★:だから好きな格好で好きなように日常を楽しむそういう時間を持ってほしかったんだ
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_10020050")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",0.4)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:それでこんなことをでも、僕が女の子らしくなんて…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_10020051")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",0.1)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Normal")

	--★★フィエナ★★:もし本当に嫌だったら<br>嫌って言ってくれていいんだよ？
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_10020053")

-- ▼直接出力
PlayPartVoice("フィエナ", "肯定")
-- ▲直接出力

	--★★フィエナ★★:たまにはケンカもしようよ私たちはお姫様とそれに仕える騎士じゃない
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_10020054")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フィエナ", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★フィエナ★★:家族でしょ？
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_10020055")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",0.4)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガラハッド", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガラハッド★★:はい…はい、姉上！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_10020057")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",0.1)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("フィエナ", "否定")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★フィエナ★★:でも、ほんとにケンカになったら手加減してね？
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_10020058")

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("フィエナ", "挨拶")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★フィエナ★★:私ね、ガラハッドが女の子の服に憧れてたこと知ってるんだから！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_10020060")


	--★★フィエナ★★:私がかわいいドレスを着てるといつもキラキラした瞳で見てたでしょ！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_10020061")

	change_face(Actor003,"Anger")

	--★★フィエナ★★:なのに自分の番になると恥ずかしがるんだもん
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_10020062")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",0.8)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ガラハッド", "照れ")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ガラハッド★★:そ、それは！姉上のほうがかわいいから…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_10020063")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",0.1)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フィエナ", "怒り")
-- ▲直接出力

	--★★フィエナ★★:それはそうかもしれないけど今は話が別だよ！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_10020064")

	change_face(Actor001,"Normal")

	--★★ノワール★★:（かわいいを否定はしないんだな）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101028_10020065")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★フィエナ★★:でも、今は恥ずかしさよりも楽しさのほうが大きくなったでしょ？
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_10020066")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("フィエナ", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★フィエナ★★:それが大事なの！自分に素直に、楽しく振る舞うのが一番！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_10020067")

	change_face(Actor003,"Normal")

	--★★フィエナ★★:毎日重い鎧を着なくてもいいんだからね！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_10020068")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",0.4)
-- ▲直接出力

	--★★ガラハッド★★:はは…姉上にはかなわないな
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_10020070")

-- ▼直接出力
PlayPartVoice("ガラハッド", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:でも、おかげで女の子らしく過ごす楽しさを知りました
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_10020071")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガラハッド", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガラハッド★★:ですから、今度こそかわいい服を買いに行きましょう
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_10020072")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",0.1)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フィエナ", "肯定")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★フィエナ★★:うん！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_10020074")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_ガラハッド_ランクアップ10_3")
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
	load_area_scene_preload(111016)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101036","001","101036001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111016_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
