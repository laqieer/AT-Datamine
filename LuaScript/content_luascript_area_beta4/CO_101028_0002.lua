-- このluaスクリプトは、CO_101028_0002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112021_01","112021_01_h")
Include("content_adv_advsmall_112021_01","Template112021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",95,CharaPos112021_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112021_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_003)
	InitializeTemplateRandomCamera112021_01()
	InitializeTemplate112021_01()
-- ▼直接出力
turn_lookat(Actor002,Actor001, 0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112021)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ガラハッド", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:いつ来ても人が多いな、ここは
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_00010008")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:悪いこういう場所は苦手だったか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_00010009")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:いや、そんなことはない
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_00010010")


	--★★ガラハッド★★:確かに見ず知らずの人間と話すのはそれほど得意ではないが
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_00010011")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ガラハッド★★:だからといって誰かと話すのが嫌いというわけではないつもりだ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_00010012")

-- ▼直接出力
setup_small_camera_start(RndCamera009)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガラハッド", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガラハッド★★:それに、街が賑やかなのは良いことだガラハッドはそう思う
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_00010013")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:そうか。それはよかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_00010014")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ガラハッド", "笑い")
-- ▲直接出力

	--★★ガラハッド★★:皆が楽しく笑い合えるそれが世界の正しい在りかたであるはずだ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_00010015")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:皆のために騎士として一層精進せねばな
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_00010016")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:ああ、お互い頑張ろう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_00010017")

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★ガラハッド★★:ところで…今日はどこへ行くつもりなんだ？マーケットに来たなら目的があるのだろう？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_00010018")

	open_select_window_tag(Actor001,"Normal","CO_101028_00010019","CO_101028_00010020","CO_101028_00010021")
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
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そうだな<br>雑貨屋でも覗きに行かないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_00010023")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ガラハッド", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:雑貨屋に？ガラハッドとノワールとでか？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_00010024")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:このあいだ、ガラハッドに似合いそうなかわいいアクセサリーを見つけたんだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_00010025")

	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:なっ…！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_00010026")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ガラハッド", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ガラハッド★★:お、お前！お前は普段からそそそ、そんなこと考えてるのか？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_00010027")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ガラハッド★★:その、ガラハッドになにが似合いそうだとか…ガラハッドと一緒にだとか…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_00010028")

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("ガラハッド", "怒り")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ガラハッド★★:不潔だ！破廉恥だ！騎士の風上にも置けぬ行為だ！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_00010029")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:たまたま見かけてなんとなく思っただけだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_00010030")

-- ▼直接出力
PlayPartVoice("ガラハッド", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:た、たまたま？なんとなく？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_00010031")

-- ▼直接出力
PlayPartVoice("ガラハッド", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:…そうか。わかった
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_00010032")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:お前はそういう奴なんだなガラハッドは、慣れることにする
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_00010033")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:どういうことだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_00010034")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:屋台で買い食いなんかどうだ？そこのホットドッグとか旨いぞ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_00010037")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:買い食いか…<br>ガラハッドはあまりしたことがない
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_00010038")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガラハッド", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:行儀がいいこととは思えないし<br>それに衛生的にも、抵抗がある
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_00010039")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:そっか。ガラハッドは綺麗好きだもんな<br>無理強いはしないほうがいいよな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_00010040")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:それにここのホットドッグは食べるのがとにかく難しいからな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_00010041")

	change_face(Actor001,"Laugh")

	--★★ノワール★★:初回からソースを零さずに食べられたのは<br>ランスロットくらいなもんだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_00010042")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガラハッド", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:…気が変わったノワール、そのホットドッグ屋に行こう
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_00010043")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_00010044")

	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Anger")

	--★★ガラハッド★★:ホットドッグくらいガラハッドだって綺麗に食べてみせる…！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_00010045")

	change_face(Actor002,"Anger")

	--★★ガラハッド★★:急いで準備をしろ、ノワール！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_00010046")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:（なんか、変にガラハッドの闘争心に<br>火をつけてしまったみたいだ…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101028_00010047")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:うーん…そう言われてみればこれといった目的は特にないな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_00010050")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ガラハッド", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:なに？<br>お前は目的もなくガラハッドを誘ったのか？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_00010051")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:なんというかさ<br>最近色々立て込んでただろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_00010052")

	change_face(Actor001,"Laugh")

	--★★ノワール★★:息抜きが必要だと思ったんだよ<br>俺にも、ガラハッドにも
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_00010053")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Laugh")

	--★★ノワール★★:こうやってただ街をブラつくのも<br>なかなかいい気分転換になるんじゃないかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_00010054")

-- ▼直接出力
PlayPartVoice("ガラハッド", "納得")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:なるほど…<br>お前は意外と気遣いのできる男なんだな
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_00010055")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガラハッド", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガラハッド★★:ガラハッドは見直した
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_00010056")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Normal")

	--★★ノワール★★:それはよかった…のかな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_00010057")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:そうだ。せっかくだし、このあとの予定は<br>ガラハッドに決めてもらおうかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_00010058")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:どこか行きたいところとか<br>やりたいことはあるか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_00010059")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ガラハッド", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガラハッド★★:ガラハッドが決めていいのか？<br>それなら、えーっとだな…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_00010060")

-- ▼直接出力
PlayPartVoice("ガラハッド", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:うーん…<br>いきなり振られても思いつかないものだな
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_00010061")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Laugh")

	--★★ノワール★★:じゃあ、考えながら<br>少しこのあたりをブラついてみるか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_00010062")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガラハッド", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:そうしよう<br>でも、もしも思いつかなかったらどうする？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_00010063")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:それならそれでいいんじゃないか？<br>なんたって息抜きなんだしさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_00010064")

	goto Block1end

::Block1end::
-- ▼直接出力
kizuna_gaugeup(Actor002,"ガラハッド")
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
	load_area_scene_preload(112021)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
