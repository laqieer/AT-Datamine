-- このluaスクリプトは、MA_01C110_31.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110091_01","110091_01_h")
Include("content_adv_advsmall_110091_01","Template110091_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110091_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110091_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_001)
	InitializeTemplateRandomCamera110091_01()
	InitializeTemplate110091_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115100)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("マーリン", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マーリン★★:………ああ、ノワール様
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C110_310002")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★マーリン★★:あなたには辛い経験をさせてしまいました
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C110_310003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "否定")
-- ▲直接出力

	--★★ノワール★★:そんなことはありません
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_310004")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01C110_310005","MA_01C110_310006")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:みんなのおかげで<br>ちゃんと帰って来れましたし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_310008")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("マーリン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マーリン★★:少し雰囲気が変わりましたね<br>大人っぽくなった…といえばいいのでしょうか
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C110_310009")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:そうですか？<br>みんなにも言われました
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_310010")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マーリン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マーリン★★:あの森にいた影響かもしれませんね
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C110_310011")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:ディナタンがあの森について知っていたようで<br>それほど苦労はありませんでした
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_310013")

	change_face(Actor001,"Normal")

	--★★ノワール★★:空腹や眠気もあまり感じなかったし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_310014")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:でも…変なんですよね<br>俺はあの森のこと、知らないんです
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_310015")

	change_face(Actor001,"Sad")

	--★★ノワール★★:俺とディナタンはこれまでずっと一緒にいた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_310016")

	change_face(Actor001,"Normal")

	--★★ノワール★★:ディナタンが知っていて<br>俺が知らない場所なんてあるとは思えない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_310017")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("マーリン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マーリン★★:…そういう森ですから
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C110_310018")

	goto Block1end

::Block1end::
	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Normal")

	--★★ノワール★★:…今、森のなかであったことが<br>なにも思い出せないんです
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_310020")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:あの森…マーリン様は知っているんですか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_310021")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マーリン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マーリン★★:そうですね…<br>あの森はもともと、妖精たちの森でした
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C110_310022")

	change_face(Actor002,"Sad")

	--★★マーリン★★:そしてニニアンがかつて暮らしていた場所
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C110_310024")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor001,"Surprise")
-- ▼直接出力
wait_time(1.8)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	close_cutin()

	--★★ノワール★★:ニニアン！？<br>ニニアンって、父さ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_310025")

	change_face(Actor001,"Sad")

	--★★ノワール★★:いや、『妖精殺し』に殺された妖精？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_310026")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:そんな場所にどうして俺たちが…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_310027")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マーリン", "悩む")
-- ▲直接出力

	--★★マーリン★★:森自身の意志…<br>いえ、妖精たちの総意かもしれません
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C110_310028")

	change_face(Actor001,"Normal")

	--★★ノワール★★:妖精たちの総意？<br>どういうことです？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_310029")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★マーリン★★:妖精についてどう考えていますか？
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C110_310030")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:妖精は、聖杯の導き手だと<br>そう…授業で習いましたけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_310031")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マーリン", "肯定")
-- ▲直接出力

	--★★マーリン★★:それは合っています<br>でもそれだけの存在だと思いますか
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C110_310032")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:聖杯の導き手以外に<br>妖精の役割がある…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_310034")

	change_face(Actor002,"Sad")

	--★★マーリン★★:役割…そうですね、役割かもしれません
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C110_310035")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("マーリン", "悲しみ")
-- ▲直接出力

	--★★マーリン★★:でも今はまだ私から<br>お話できることはありません
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C110_310036")


	--★★マーリン★★:ただ…アーサー様がこんなことになったのも<br>もとはといえば妖精たちのせい
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C110_310037")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:妖精たちのせい？魔女ではなく？<br>いったい、どういうことですか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_310038")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:教えてください、マーリンさん！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_310039")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マーリン", "落胆")
-- ▲直接出力

	--★★マーリン★★:…申し訳ございません<br>まだ、お話できないのです
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C110_310040")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Anger")

	--★★マーリン★★:今はただ待ちましょう。時が来るのを
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C110_310041")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115100)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110091_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
