-- このluaスクリプトは、MA_01B109_18.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112031_01","112031_01_h")
Include("content_adv_advsmall_112031_01","Template112031_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-74,CharaPos112031_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112031_01,CameraPos112031_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112031_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleName112031_01,CameraPos112031_01_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPos112031_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleName112031_01,CameraPos112031_01_005)
	InitializeTemplateRandomCamera112031_01()
	InitializeTemplate112031_01()
-- ▼直接出力
Hide(Actor002)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(116037)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor003)
DontChangeRandomCamera(true)
-- ▲直接出力
	PlayAction(Actor003,"to Greet_one")

	--★★クレア★★:いらっしゃい<br>御用を当てましょうか
	Talk(Actor003,"CHRNAME_CLARE","speech","L","MA_01B109_180002")

-- ▼直接出力
CloseTalkWindow()
OpenFirstAppearance(Actor003)
-- ▲直接出力
-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("クレア", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★クレア★★:鞘の金具をお求めね<br>５ゼニーになるわ
	Talk(Actor003,"CHRNAME_CLARE","speech","L","MA_01B109_180003")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:俺はまだなにも話してないけど…！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_180004")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("クレア", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★クレア★★:上着が汚れている<br>つまり、あなたは訓練から戻ったばかり
	Talk(Actor003,"CHRNAME_CLARE","speech","L","MA_01B109_180005")


	--★★クレア★★:しかし訓練帰りにも関わらず帯剣していない<br>ということは帯剣できない理由があるということ
	Talk(Actor003,"CHRNAME_CLARE","speech","L","MA_01B109_180006")


	--★★クレア★★:そしてあなたの視線はベルトのような<br>皮革製品ではなく金具類のある場所を見ていた
	Talk(Actor003,"CHRNAME_CLARE","speech","L","MA_01B109_180007")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Smile")

	--★★クレア★★:つまり、あなたが求めているのは<br>帯剣するために必要な金具。簡単な推理よ
	Talk(Actor003,"CHRNAME_CLARE","speech","L","MA_01B109_180008")


	--★★ノワール★★:は、はあ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_180009")

-- ▼直接出力
CloseTalkWindow()
EntryWalk(Actor002,Camera002,EntryData112031_01_04,CameraAssetBundleName112031_01,CameraPos112031_01_104)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ヴォールス", "落胆")
-- ▲直接出力

	--★★ボールス★★:すまん<br>目と口と鼻が利き過ぎる娘でな
	Talk(Actor002,"CHRNAME_BORS","speech","L","MA_01B109_180011")


	--★★ノワール★★:は、はあ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_180012")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ボールス★★:鞘の金具だったな？<br>５ゼニーだ
	Talk(Actor002,"CHRNAME_BORS","speech","L","MA_01B109_180014")

	open_select_window_tag(Actor001,"Normal","MA_01B109_180015","MA_01B109_180016")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ついでに装備の整備を頼んでいいか？<br>剣が刃こぼれしていて
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_180018")

-- ▼直接出力
 --PlayPartVoice("ヴォールス", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ボールス★★:見せてみろ
	Talk(Actor002,"CHRNAME_BORS","speech","L","MA_01B109_180019")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ボールス★★:…ずいぶん使い込んでるな
	Talk(Actor002,"CHRNAME_BORS","speech","L","MA_01B109_180021")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Normal")

	--★★ノワール★★:貧乏性というかなんというか<br>…苦手なんだよ、物を棄てるの
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_180022")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ヴォールス", "納得")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ボールス★★:…この剣も喜んでいる<br>お前がよく着ているコートもな
	Talk(Actor002,"CHRNAME_BORS","speech","L","MA_01B109_180023")

	change_face(Actor002,"Smile")

	--★★ボールス★★:装備を粗末にしないヤツは信用できる
	Talk(Actor002,"CHRNAME_BORS","speech","L","MA_01B109_180024")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:えっと…クレア、だっけ<br>あんたのキラーズなんだよな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_180026")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ヴォールス", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ボールス★★:そうだ
	Talk(Actor002,"CHRNAME_BORS","speech","L","MA_01B109_180027")

-- ▼直接出力
 --PlayPartVoice("ヴォールス", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ボールス★★:口下手ゆえ、いろいろと面倒もかけると思うが<br>大目に見てやってくれ
	Talk(Actor002,"CHRNAME_BORS","speech","L","MA_01B109_180028")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:あ、ああ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_180029")

	change_face(Actor001,"Normal")

	--★★ノワール★★:（口下手なのは<br>キラーズだけじゃなさそうだな）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","MA_01B109_180030")

	goto Block1end

::Block1end::
	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Sad")

	--★★ボールス★★:聖杯探索班として挨拶に来てくれたのだな<br>…すまないが俺たちはすぐには出られない
	Talk(Actor002,"CHRNAME_BORS","speech","L","MA_01B109_180032")

-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:工房の仕事と騎士の務めを両立してるんだ<br>しょうがないよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_180033")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ヴォールス", "肯定")
-- ▲直接出力

	--★★ボールス★★:…ああ<br>前の戦いの影響でバタついていてな
	Talk(Actor002,"CHRNAME_BORS","speech","L","MA_01B109_180034")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("クレア", "挨拶")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★クレア★★:銀卓騎士団が<br>いるのでしょう？
	Talk(Actor003,"CHRNAME_CLARE","speech","L","MA_01B109_180036")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_180038")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★ボールス★★:…クレア
	Talk(Actor002,"CHRNAME_BORS","speech","L","MA_01B109_180040")


	--★★クレア★★:ガラハッドは…無知ね<br>純真で、良くも悪くも一生懸命
	Talk(Actor003,"CHRNAME_CLARE","speech","L","MA_01B109_180042")

	PlayAction(Actor003,"to  Std_No")

	--★★クレア★★:でも、『聖杯城の巫女』を名乗る子…<br>フィエナは無垢を装っているけれど不透明よ
	Talk(Actor003,"CHRNAME_CLARE","speech","L","MA_01B109_180044")

-- ▼直接出力
 --PlayPartVoice("ヴォールス", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ボールス★★:クレア
	Talk(Actor002,"CHRNAME_BORS","speech","L","MA_01B109_180046")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★クレア★★:報告は聞いたわ。聖杯城はバルバロイにより陥落<br>彼女らは命からがら逃げ延びて今に至ると
	Talk(Actor003,"CHRNAME_CLARE","speech","L","MA_01B109_180047")


	--★★クレア★★:だけど精鋭揃いの銀卓がそう簡単に敗れる？<br>それもログレスが一度は制した戦いのあとに
	Talk(Actor003,"CHRNAME_CLARE","speech","L","MA_01B109_180049")

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("クレア", "悩む")
-- ▲直接出力

	--★★クレア★★:普通に考えれば仇を取るべく円卓に協力…<br>となりそうだけど、なにか引っかかるわ
	Talk(Actor003,"CHRNAME_CLARE","speech","L","MA_01B109_180050")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ボールス★★:円卓は彼らの協力を受け入れた<br>足並みを乱す疑いはよせ
	Talk(Actor002,"CHRNAME_BORS","speech","L","MA_01B109_180051")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ヴォールス", "怒り")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ボールス★★:…すまないな。ノワール
	Talk(Actor002,"CHRNAME_BORS","speech","L","MA_01B109_180053")

	change_face(Actor002,"Normal")

	--★★ボールス★★:クレアの懸念があるから…というわけではないが<br>今俺たちが行くことは少し難しい
	Talk(Actor002,"CHRNAME_BORS","speech","L","MA_01B109_180054")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★クレア★★:気を付けて継承者
	Talk(Actor003,"CHRNAME_CLARE","speech","L","MA_01B109_180056")


	--★★クレア★★:あなたの選んだこの運命には誰もが沈黙している<ruby=あまた>数多</ruby>の<dot>本当</dot>が隠されている
	Talk(Actor003,"CHRNAME_CLARE","speech","L","MA_01B109_180057")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("クレア", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★クレア★★:せいぜい足を引っ張られないようにね
	Talk(Actor003,"CHRNAME_CLARE","speech","L","MA_01B109_180059")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(116037)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112031_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
