-- このluaスクリプトは、CO_101062_0502.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112021_03","112021_03_h")
Include("content_adv_advsmall_112021_03","Template112021_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112021_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112021_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_012_01_StdController","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos112021_03_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_506_01_StdController","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_004)
	InitializeTemplateRandomCamera112021_03()
	InitializeTemplate112021_03()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112021)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101062","001","101062001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401022","001","401022001","content_animationpack__common","FacialPack","Actor003")
	template1()
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")

end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("マルイル", "肯定")
-- ▲直接出力

	--★★マルイル★★:実はぼく、こことは別に/実家から任されてひとつ店を経営してるんです
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_05020002")


	--★★マルイル★★:ずっと旅商人をしていたので/ほとんど知人に任せきりなんですが
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_05020003")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("マルイル", "肯定2")
-- ▲直接出力

	--★★マルイル★★:それでも一応こうして/定期的に業務報告をもらっているんです
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_05020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力

	--★★ノワール★★:へえ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_05020005")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101062_05020007","CO_101062_05020008","CO_101062_05020009")
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
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:けどなんで自分の店があるのに/ログレスで店を始めたんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_05020011")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("マルイル", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:ぼくの手で、イチからお店を作りたかったんです/実家から任されたお店じゃなくて
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_05020012")

	change_face(Actor002,"Smile")

	--★★マルイル★★:それができてはじめて/一人前、って感じがするじゃないですか
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_05020013")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そもそもなんで旅商人なんてやってたんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_05020015")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("マルイル", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:それはもちろん/世界中のまだ見ぬ商品に出会うため、ですよ！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_05020016")

	change_face(Actor002,"Normal")

	--★★マルイル★★:それに、ぼくはまだまだ未熟ですから/旅をすればもっと成長できるかなと思って
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_05020017")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:その若さで/ふたつも店を持ってるなんてすごいな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_05020019")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マルイル", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★マルイル★★:いやいや、そんなことないですよ/知人のフォローがあってこそですから
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_05020020")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:けど、信頼できる人間がそばにいることも含めて/あんたの器ってことだろ。やっぱりすごいよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_05020021")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マルイル", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:そう…なんですかね/でも、そう言ってもらえて嬉しいです
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_05020022")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("マルイル", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルイル★★:ぼくは商人の家系に生まれたんです/五人兄弟の末っ子です
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_05020024")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:わかる。末っ子っぽいよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_05020025")

-- ▼直接出力
PlayPartVoice("マルイル", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:えへへ、そうですか？/やっぱり、出ちゃうんですかね
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_05020026")

	change_face(Actor002,"Normal")

	--★★マルイル★★:ぼくも家族に甘やかされたという自覚はあります/自分で言うのもなんですが、甘え上手なので
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_05020027")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("マルイル", "肯定2")
-- ▲直接出力

	--★★マルイル★★:特に祖父は、ぼくのことを/とてもかわいがってくれました
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_05020029")


	--★★マルイル★★:「マルイルには商人に必要な愛嬌もあるし/目利きの腕前も群を抜いている」
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_05020030")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★マルイル★★:「きっとマルイルは、たくさんの客と/品物を繋ぐ世界一の商人になれる」って
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_05020031")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力

	--★★ノワール★★:前に言ってたお爺さんか/ずいぶん認められてたんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_05020032")

-- ▼直接出力
PlayPartVoice("マルイル", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マルイル★★:…ぼくも、そう思ってたんです。でも…
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_05020033")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad02")

	--★★マルイル★★:商人になったぼくが家から任されたのは/へんぴな地の小さなお店でした
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_05020034")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:どういうことだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_05020035")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("マルイル", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルイル★★:うちは世界中に店を持っていて、独り立ちのさい/必ずどこかの店舗を任されるんです
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_05020036")


	--★★マルイル★★:ぼくは末っ子で、家督は継がせてもらえないから/一番大きな店が任せられることはない
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_05020037")

-- ▼直接出力
PlayPartVoice("マルイル", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マルイル★★:それはわかってました。だけど…
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_05020038")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:兄弟が自分より/いい店を任されたのが不満、ってことか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_05020039")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マルイル", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★マルイル★★:そういうわけじゃありません！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_05020040")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("マルイル", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マルイル★★:ただ、もっといい条件の店はたくさんあるのに/どうしてあの店なんだろう、って思って
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_05020041")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:俺は商人じゃないから想像もつかないけど/なにか意味があったんだろうな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_05020042")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マルイル", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルイル★★:そうなんだとは思います/ぼくにとっては都合は良かったんですけどね
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_05020043")


	--★★マルイル★★:もっとたくさんのお客さんに商品を売りたい…/世界一の商人になるために見識を広めたい…
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_05020044")


	--★★マルイル★★:どうしても欲しいのに手に入らない/そんなお客さんの願いを繋ぎたい…
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_05020045")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("マルイル", "肯定2")
-- ▲直接出力

	--★★マルイル★★:だったら旅商人になればいいじゃないか<br>いつからか、ぼくはそんな考えを抱いていました
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_05020046")

-- ▼直接出力
setup_small_camera_start(Camera002)
Appear(Actor003)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("マルイル", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マルイル★★:それに、世界一の商人になればきっと――
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_05020048")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to Greet_one")
-- ▼直接出力
PlayPartVoice("市民中年_女2", "挨拶")
-- ▲直接出力

	--★★市民（中年女）②★★:マルイル、ちょっといいかしら/探してるものがあるんだけど…
	Talk(Actor003,"NPCNAME_0256","speech","N","CO_101062_05020050")

-- ▼直接出力
PlayPartVoice("マルイル", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:はーい！/今お伺いします！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_05020051")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルイル★★:ノワールさん、話の途中ですがすみません/今日はこれで！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_05020052")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…あいつ、なにか言いかけてたような/なんだったんだろう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_05020054")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
local trustParam = set_communication_rankup("マルイル_コミュランク", "マルイル_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
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
	load_area_scene_preload(112021)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101062","001","101062001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401022","001","401022001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112021_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
