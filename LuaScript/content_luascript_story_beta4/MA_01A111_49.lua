-- このluaスクリプトは、MA_01A111_49.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112011_01","112011_01_h")
Include("content_adv_advsmall_112011_01","Template112011_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112011_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName112011_01,CameraPos112011_01_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112011_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName112011_01,CameraPos112011_01_002)
	InitializeTemplateRandomCamera112011_01()
	InitializeTemplate112011_01()
-- ▼直接出力
 --stillAnime = load_ui_effect("content_still_10104005_anim", "10104005_StillAnim", nil, nil, nil, "Root")
load_image("101030290", "content_still_10103029_image", "101030290_StillImage")


-- ▲直接出力
-- ▼直接出力
Ef_VanishDust = load_particle("content_effect3d_common_adv","Ef_C_Adv_VanishDust", false, true) --聖遺物化予兆
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112011)
	Actor001 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:消えてなくなっちゃいたい
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_490002")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:…って思うこと、ある？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_490003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ラグネル", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ラグネル★★:まさに、ここ最近
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","MA_01A111_490004")

	change_face(Actor001,"Normal")

	--★★ラグネル★★:──ハロウィン<br>できたらなぁって思ってたの
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","MA_01A111_490006")

-- ▼直接出力
CloseTalkWindow()
show_image("101030290", 0.0, 0.0, STILL_SWITCH_TIME ,true,false)
wait_time(STILL_SWITCH_TIME + STILL_ACTIVE_AFTER)
 --[[
fadeout(0, 0, 0, 0, STILL_SWITCH_TIME )
	wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER)
	stillAnime.SetActive(true)
	fadein(0.5)
	local signal = play_ui_timeline_controller_in(stillAnime)
	while signal.IsProccessing() do
		coroutine.yield()
	end
 --]]
-- ▲直接出力

	--★★ラグネル★★:この時期は魔女の力が増すって言い伝え<br>あるんだって
	Talk(Actor001,"CHRNAME_RAGNAR","simple","N","MA_01A111_490008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ラグネル★★:だからかな、気のせいかもしんないけど<br>…全然うまくいかなかったね
	Talk(Actor001,"CHRNAME_RAGNAR","simple","N","MA_01A111_490009")


	--★★ラグネル★★:そんな魔女から自分たちを守るために<br>同じ魔女の格好をしてその目を欺く──
	Talk(Actor001,"CHRNAME_RAGNAR","simple","N","MA_01A111_490010")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ラグネル★★:そんな趣旨で始まったのが<br>ハロウィンらしいけど
	Talk(Actor001,"CHRNAME_RAGNAR","simple","N","MA_01A111_490011")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力

	--★★ギネヴィア★★:なんでこの時期に魔女の力が増すのよ<br>フコーヘー
	Talk(Actor002,"CHRNAME_GUINEVERE","simple","N","MA_01A111_490013")


	--★★ラグネル★★:ただの言い伝えだよ？<br>実際にそうかは知らないけどね
	Talk(Actor001,"CHRNAME_RAGNAR","simple","N","MA_01A111_490014")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力

	--★★ギネヴィア★★:…でも、いいな。ハロウィン<br>みんなで好きな仮装をして街を練り歩いて…
	Talk(Actor002,"CHRNAME_GUINEVERE","simple","N","MA_01A111_490015")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ラグネル", "肯定")
-- ▲直接出力

	--★★ラグネル★★:あたしね。手芸サークルの子たちと<br>衣装を作ってたんだ
	Talk(Actor001,"CHRNAME_RAGNAR","simple","N","MA_01A111_490016")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ラグネル★★:ディナタンちゃんとかマルディサントちゃんとか<br>可愛くて大騒ぎになるだろうし
	Talk(Actor001,"CHRNAME_RAGNAR","simple","N","MA_01A111_490017")


	--★★ラグネル★★:ヴェルナルス…先生とかは<br>そういうのイヤがるだろうから
	Talk(Actor001,"CHRNAME_RAGNAR","simple","N","MA_01A111_490018")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ラグネル", "笑い")
-- ▲直接出力

	--★★ラグネル★★:逆にすんごい恥ずかしい服作ってあげよう…<br>とか張り切ったりなんかして
	Talk(Actor001,"CHRNAME_RAGNAR","simple","N","MA_01A111_490019")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ラグネル★★:張り切ったぶんだけ<br>むなしくなっちゃった
	Talk(Actor001,"CHRNAME_RAGNAR","simple","N","MA_01A111_490020")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ギネヴィア★★:………うまくいかないね
	Talk(Actor002,"CHRNAME_GUINEVERE","simple","N","MA_01A111_490021")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ラグネル★★:うん。うまくいかない<br>なんかね…バカみたいで
	Talk(Actor001,"CHRNAME_RAGNAR","simple","N","MA_01A111_490022")

-- ▼直接出力
	CloseTalkWindow()
hide_image(STILL_SWITCH_TIME)
 --[[
	signal = play_ui_timeline_controller_out(stillAnime, true)
	while signal.IsProccessing() do
		coroutine.yield()
	end
fadeout(0, 0, 0, 0, STILL_SWITCH_TIME)
	wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER)
stillAnime.SetActive(false)
fadein(STILL_SWITCH_TIME)
 --]]
wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:…キラーズとして戦い続けると<br>記憶が失われていくっていうでしょ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_490024")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ギネヴィア★★:ラグネルはどう？<br>記憶が薄れていったりしてない？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_490025")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ラグネル", "肯定")
-- ▲直接出力

	--★★ラグネル★★:ガウェインのバイブスが<br>あたしの存在を繋ぎとめてくれてるから
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","MA_01A111_490026")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ラグネル★★:平気、だけど…ギネヴィア？
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","MA_01A111_490027")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ギネヴィア★★:…わたしは、ね<br>なんでなんだろう
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_490028")

	PlayAction(Actor002,"to  Std_Sad01")

	--★★ギネヴィア★★:なんか…ぽっかりと──<br>…忘れちゃってること、あるの
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_490029")

-- ▼直接出力
CloseTalkWindow()
on_active(Ef_VanishDust)
local getcharapos = get_pos(Actor002)
set_pos(Ef_VanishDust, getcharapos)
play_particle(Ef_VanishDust)
wait_time(1.0)
stop_particle(Ef_VanishDust)
-- ▲直接出力

	--★★ギネヴィア★★:なにかきっかけがあれば、ね？<br>思い出せる…んだけど
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_490031")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ラグネル", "苦しみ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ラグネル★★:う、そ…でしょ、どうして…！？<br>そんな早く──…
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","MA_01A111_490032")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:………わたしの『存在』を力に換えて<br>武器として戦うのがキラーズよね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_490034")

	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:その『存在』が摩耗し切った時<br>『<ruby=ゲシュタルト・ロスト>存在消失</ruby>』が起こる…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_490035")


	--★★ギネヴィア★★:そうなれば、わたしの体の『存在』は消え<br>武器そのもの──聖遺物と化す
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_490037")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ラグネル★★:…キラーズだった人のことを覚えていられるのは<br>GSした持ち主と継承者だけになる
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","MA_01A111_490038")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ギネヴィア★★:…あとに残るのは聖遺物だけ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_490040")

-- ▼直接出力
CloseTalkWindow()
on_active(Ef_VanishDust)
local getcharapos = get_pos(Actor002)
set_pos(Ef_VanishDust, getcharapos)
play_particle(Ef_VanishDust)
wait_time(1.0)
stop_particle(Ef_VanishDust)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ラグネル", "悩む")
-- ▲直接出力

	--★★ラグネル★★:みんなね、いつ消えちゃうか怯えてる<br>だけどマスターが覚えててくれれば…
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","MA_01A111_490042")

	change_face(Actor001,"Sad")

	--★★ラグネル★★:バルバロイを討つ力となるなら<br>歴史に武器としてでも名が遺るなら…って
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","MA_01A111_490043")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ラグネル★★:たくましいよね、みんな
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","MA_01A111_490044")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:ラグネルもそうだった…？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_490045")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ラグネル", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ラグネル★★:あたしはね…、あはは
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","MA_01A111_490046")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ラグネル★★:危なっかしいんだ、アイツ<br>だからかな
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","MA_01A111_490047")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ラグネル★★:けど、なんかね…うまくいかないね
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","MA_01A111_490048")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定")
-- ▲直接出力

	--★★ギネヴィア★★:うん<br>初めは張り切っちゃうんだけどね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_490049")


	--★★ギネヴィア★★:チンケなわたしが、一国の王に見出されて<br>「わたしこれから世界を救うんだ」って
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_490050")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ギネヴィア★★:百戦錬磨のアーサーの代わりに<br>強い王妃になってみせようって
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_490051")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
CloseTalkWindow()
on_active(Ef_VanishDust)
local getcharapos = get_pos(Actor002)
set_pos(Ef_VanishDust, getcharapos)
play_particle(Ef_VanishDust)
wait_time(1.0)
stop_particle(Ef_VanishDust)
 --PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:でも、てんで──…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_490052")

-- ▼直接出力
 --PlayPartVoice("ラグネル", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ラグネル★★:弱いわけないじゃん、ギネヴィアは
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","MA_01A111_490054")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力

	--★★ギネヴィア★★:王妃でいろって言われても<br>うまく出来ない…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_490055")


	--★★ギネヴィア★★:武器になれって言われても<br>うまく出来ない…！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_490056")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "苦しみ")
-- ▲直接出力

	--★★ギネヴィア★★:いますぐ消えてなくなりたいのに<br>それはそれで怖くてしょうがないよ…！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_490057")

-- ▼直接出力
 --_active(Ef_VanishDust)
-- ▲直接出力

	--★★ギネヴィア★★:わたしはどうなればいいかな…<br>これからどうすればいいのかな…！？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_490058")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★ギネヴィア★★:お姉ちゃんに、あんな悲しそうな顔…<br>もうさせたくないよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_490059")

	PlayAction(Actor002,"to  Std_Sad01")

	--★★ギネヴィア★★:彼の傍にいたいよ──…<br>それだけなのに──…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_490060")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ラグネル★★:………うん
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","MA_01A111_490061")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:がんばったぶんだけ<br>削られてくだけで
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_490062")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:わたし、あとどれくらい<br>こうしていられるの？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_490063")

-- ▼直接出力
setup_small_camera_start()
on_active(Ef_VanishDust)
local getcharapos = get_pos(Actor002)
set_pos(Ef_VanishDust, getcharapos)
play_particle(Ef_VanishDust)
-- ▲直接出力

	--★★ギネヴィア★★:のこせるものって、あるの？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_490064")

-- ▼直接出力
wait_time(1.0)
stop_particle(Ef_VanishDust)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101030290", "content_still_10103029_image", "101030290_StillImage")
load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_VanishDust", false, true)
	InitializeLoad_Preload()
	load_area_scene_preload(112011)
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112011_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
