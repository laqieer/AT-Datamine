-- このluaスクリプトは、MA_01B112_13.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_05","110011_05_h")
Include("content_adv_advsmall_110011_05","Template110011_05_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_05_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110011_05,CameraPos110011_05_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_05_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_SitController","to Sit01_Loop",CameraAssetBundleName110011_05,CameraPos110011_05_002)
	InitializeTemplateRandomCamera110011_05()
	InitializeTemplate110011_05()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115014)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★ガラハッド★★:僕を好きと言ってくれた人
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_130002")


	--★★ガラハッド★★:そのふたり目が──アステラだった
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_130003")

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:僕は、実の母に「好き」と言われた記憶はない<br>けれど僕はどうやら母上のことが好きだった
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_130005")


	--★★ガラハッド★★:母上に好いてもらうには今の自分じゃダメだと<br>色んな人の真似をしたりした
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_130006")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ガラハッド★★:母上を守れるように強くなろうとした<br>だが結局、僕の力は及ばず…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_130007")

	change_face(Actor002,"Normal")

	--★★ガラハッド★★:屍と化した母上を誰にも触れさせないよう<br>森のなか、泣きながら木の棒を振り回していた
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_130008")


	--★★ノワール★★:そこに…アステラが？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_130009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:幼い目にも無敵だったよ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_130010")

	change_face(Actor002,"Normal")

	--★★ガラハッド★★:僕を受け入れてくれた銀卓の皆も<br>素人目に見ても卓越した強さだった
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_130011")


	--★★ガラハッド★★:僕はそれからずっと彼らの虜だった<br>好きと言われたくて
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_130012")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:…はじめて「好き」と言われたのは？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_130013")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ガラハッド★★:わかるだろう？姉上だ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_130014")

	change_face(Actor002,"Sad")

	--★★ガラハッド★★:アステラは見ていたんだろうな<br>そう言われて喜んだ僕の顔を
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_130015")


	--★★ガラハッド★★:事実、もっと言って欲しくて<br>ねだるような顔でいたんだろう
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_130016")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01B112_130017","MA_01B112_130018","MA_01B112_130019")
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
	change_face(Actor001,"Normal")

	--★★ノワール★★:銀卓の騎士は強いな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_130021")

	change_face(Actor002,"Smile")

	--★★ガラハッド★★:バルバロイに侵される前はあんな無口じゃなくて<br>もっと賑やかな人たちだったんだぞ？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_130022")

	change_face(Actor002,"Smile")

	--★★ガラハッド★★:強くて、たくましくて、人が良くて<br>僕の唯一の居場所で、あったかかった
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_130023")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ノワール★★:アステラは優しかったな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_130025")

	change_face(Actor002,"Smile")

	--★★ガラハッド★★:ふふ。わかるか
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_130026")

	change_face(Actor001,"Smile")

	--★★ノワール★★:少し旅をしただけだったけど<br>いつもガラハッドのことを気にかけてた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_130027")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ガラハッド★★:強いから出来ることなんだ<br>好意を向けてくれるのも、強くて優しいから
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_130028")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	change_face(Actor001,"Surprise")

	--★★ノワール★★:そんなに欲張らなくても
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_130030")

	change_face(Actor002,"Sad")

	--★★ガラハッド★★:誰かに好まれたいと思うことが<br>欲張りに見えるか？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_130031")

	change_face(Actor002,"Sad")

	--★★ガラハッド★★:ガラハッドはアステラの「好き」が<br>とても嬉しかったんだ。とても…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_130032")

	goto Block1end

::Block1end::
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:姉上曰く…銀卓騎士は皆『父なる彼』の剣技を<br>受け継いでいる…ということなんだな
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_130034")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ガラハッド★★:『父なる彼』つまりは<br>ノワール…お前の父親の剣を
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_130035")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ガラハッドは違うのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_130036")

	change_face(Actor002,"Sad")

	--★★ガラハッド★★:僕は…実はな、恥ずかしい話だが<br>ずっと銀卓に入れてもらえていなかったんだ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_130037")

	change_face(Actor002,"Normal")

	--★★ガラハッド★★:だけど姉上とGSを果たしてようやく認められて<br>剣技を銀卓の皆から学んだんだ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_130039")


	--★★ガラハッド★★:だが彼らの強さは『父なる彼』から直接伝授され<br>聖杯城にて磨き続けられた至上の剣技だろう
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_130041")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ガラハッド★★:ノワールやランスロットにも<br>勝るとも劣らぬ精鋭ぞろいだ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_130042")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガラハッド★★:ガラハッドの銀卓講座だ<br>どうだった、勉強になったか
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_130043")


	--★★ノワール★★:どうしてこんなことを俺に？<br>アステラの話とか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_130044")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ガラハッド★★:憧れていたんだ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_130045")


	--★★ガラハッド★★:銀卓に、騎士に、姉上に、お爺様に<br>そもそも…家族というものに
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_130046")

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:だが知ろうとしなかった。遠ざけ、高みに置いて<br>…眺めていただけだった。その輝きを
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_130047")


	--★★ガラハッド★★:真似して自らを潔癖に磨けば磨くほど<br>銀色は輝いて、映すのは憧れた像ばかりだった
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_130048")


	--★★ガラハッド★★:鎧の中の僕は<br>誰の目にも止まらなかった
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_130049")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ガラハッド★★:僕は置いてけぼりだった
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_130050")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:だから僕はもっと勉強するんだ<br>伸びしろがあるとこの学園でわかったんだ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_130052")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ガラハッド★★:ノワール<br>まずは競争相手のお前からだ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_130053")


	--★★ノワール★★:俺…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_130054")


	--★★ガラハッド★★:僕はノワールを勉強させてもらった<br>今度は僕を勉強してくれないか、ノワール
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_130055")


	--★★ガラハッド★★:相手に知ってもらえないと『知り合い』じゃない<br>ともに学び合わないと『学友』にはなれない
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_130056")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01B112_130057","MA_01B112_130058","MA_01B112_130059")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	elseif is_select(3) then
		goto Block2_3
	end

::Block2_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ノワール★★:勉強させてもらうよ、ガラハッド
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_130061")

	change_face(Actor002,"Smile")

	--★★ガラハッド★★:こっちの台詞だ、ノワール
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_130062")

	change_face(Actor002,"Smile")

	--★★ガラハッド★★:その…ぜひガラハッドの<br>『知り合い』に、なってほしい
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_130063")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ノワール★★:俺だけじゃなくランスロットにも学ぶといい<br>あいつは学園の教師のひとりだから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_130065")

	change_face(Actor002,"Smile")

	--★★ガラハッド★★:勿論だ！お前と競いながら走る先には<br>最強騎士がいるんだ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_130066")

	change_face(Actor002,"Smile")

	--★★ガラハッド★★:いずれは彼からも多くを学び<br>彼にもガラハッドのことを学んでもらわねば！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_130067")

	goto Block2end

::Block2_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ノワール★★:もう知り合いだし、学友だよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_130069")

	change_face(Actor002,"Shy")

	--★★ガラハッド★★:えっ、あっ、そ、そうか…<br>そう、言ってくれるか…っ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_130070")

	change_face(Actor002,"Smile")

	--★★ガラハッド★★:じゃ、じゃあ…より親しい友人<br>『親友』を目指すのはどうだろう！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_130071")

	goto Block2end

::Block2end::
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:円卓の騎士は学び舎でそうやって互いを知り<br>絆を深め合っているから強いのだと思った
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_130073")

	change_face(Actor002,"Smile")

	--★★ガラハッド★★:そうやってガラハッドも強くなりたい<br>これは憧れじゃなく、学習意欲だ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_130075")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ガラハッド★★:そうやってガラハッドは<br>僕を好きになりたい
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_130076")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115014)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_05)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
