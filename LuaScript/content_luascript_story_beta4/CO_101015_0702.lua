-- このluaスクリプトは、CO_101015_0702.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110041_02","110041_02_h")
Include("content_adv_advsmall_110041_02","Template110041_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",110,CharaPos110041_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110041_02,CameraPos110041_02_002)
	Camera002 = SetTemplate("Actor002",65,CharaPos110041_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName110041_02,CameraPos110041_02_003)
	InitializeTemplateRandomCamera110041_02()
	InitializeTemplate110041_02()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110041)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("アーサー", "笑い")
-- ▲直接出力

	--★★アーサー★★:うーん、風が気持ちいいな！<br>…お、あそこにイチャついてる生徒たちが！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_07020002")

	change_face(Actor002,"Smile")

	--★★アーサー★★:あれはいわゆる壁ドンってやつか！？<br>いいなぁ、青春って感じだ！！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_07020003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:あんた、相変わらずだな…<br>そんなに好きか？青春ってやつ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_07020004")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力

	--★★アーサー★★:ああ、好きだとも！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_07020005")

	change_face(Actor002,"Normal")

	--★★アーサー★★:というより必要という方が正しいかもな<br>俺が俺であるために
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_07020006")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:どういう意味だ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_07020008")


	--★★アーサー★★:…ひとつ、昔話をしてやろう<br>俺がまだ王様でもなんでもなかった頃の話だ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_07020009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力

	--★★アーサー★★:ログレスの片田舎にある孤児院で<br>俺は毎日無邪気に遊んでいた
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_07020010")


	--★★アーサー★★:晴れた日には鬼ごっこをして<br>雨が降れば屋根の下でみんなと一緒に本を読んだ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_07020011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("アーサー", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:孤児院の掃除当番をサボっては<br>義兄さんに追いかけまわされたり
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_07020012")

	change_face(Actor002,"Normal")

	--★★アーサー★★:気になる女の子にイタズラをして泣かせて<br>先生にゲンコツをくらったこともある
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_07020013")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アーサー", "肯定")
-- ▲直接出力

	--★★アーサー★★:それからおやつのホットドッグを並んで食べて<br>どんな大人になるかと、夢を語り合ったりもした
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_07020014")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101015_07020016","CO_101015_07020017","CO_101015_07020018")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:いい思い出だな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_07020020")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:ああ。大切な思い出だ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_07020021")

	change_face(Actor002,"Normal")

	--★★アーサー★★:孤児院で育った王などと<br>俺を揶揄する者もいるが
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_07020022")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★アーサー★★:あの頃がなければきっと<br>俺はもっと早くに潰れていたさ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_07020023")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アーサー", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★アーサー★★:それか…<br>もっと王様らしくなっていたかもな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_07020024")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:今とあまり変わらないな<br>ケイ卿に追い回されたりとか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_07020026")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("アーサー", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:ハハハ！確かにな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_07020027")

	change_face(Actor002,"Smile")

	--★★アーサー★★:…って、待て<br>今の俺はマーリンを泣かせたりなど――
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_07020028")

	change_face(Actor002,"Surprise")

	--★★アーサー★★:…まったくしてない、というわけでもないが…
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_07020029")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ていうか…<br>気になる女の子ってマーリンさんだったのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_07020031")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("アーサー", "苦しみ")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★アーサー★★:ぐ…
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_07020032")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:気になる女の子ってもしかして…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_07020034")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("アーサー", "驚き")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:おっと！その先は言わぬが花というやつだ！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_07020035")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:今度本人に確認してみようかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_07020036")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アーサー", "激怒")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★アーサー★★:ぜっっっったいやめてくれ！！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_07020037")

	goto Block1end

::Block1end::
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("アーサー", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:…今思えば<br>あれが俺の青春だったんだろうな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_07020039")


	--★★アーサー★★:もう二度と戻ることのない日々<br>けれど、どれも大切な思い出だ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_07020040")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力

	--★★アーサー★★:それが胸にあるかぎり、きっと戦っていける<br>どうしようもなく辛いことがあっても
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_07020041")


	--★★アーサー★★:道を踏み外しそうになったときも<br>きっと…その思い出が支えてくれる
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_07020042")


	--★★アーサー★★:それが青春だと俺は思う
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_07020043")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:だからあんたは<br>生徒たちの青春にこだわるんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_07020044")

-- ▼直接出力
PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力

	--★★アーサー★★:ああ。俺は本来戦わなくていい若者に<br>戦うことを強いている
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_07020045")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★アーサー★★:だからせめて学園にいる短いあいだだけでも<br>最高の思い出を作ってほしい
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_07020046")


	--★★アーサー★★:俺の勝手な押し付けだ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_07020047")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:そうかもな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_07020048")


	--★★ノワール★★:けどその押し付けのおかげで<br>青春を謳歌できた生徒はきっとたくさんいる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_07020049")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:俺みたいに
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_07020050")

-- ▼直接出力
PlayPartVoice("アーサー", "肯定")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★アーサー★★:ノワール…
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_07020051")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:きっとこの思い出は俺の力になる<br>そうだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_07020052")

-- ▼直接出力
setup_small_camera_start(Camera002)
CloseTalkWindow()
wait_time(WAIT_TIME_NORMAL)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…アーサー？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_07020054")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★アーサー★★:…いや
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_07020055")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:そうだな<br>思い出はきっと、お前の力になるよ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_07020056")


	--★★アーサー★★:…さて。そろそろ戻るか！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_07020058")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("アーサー", "笑い")
-- ▲直接出力

	--★★アーサー★★:あんまりサボっていると<br>義兄さんの血管が切れてしまうからな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_07020059")

-- ▼直接出力
local trustParam = set_communication_rankup("アーサー_コミュランク", "アーサー_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
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
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110041_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
