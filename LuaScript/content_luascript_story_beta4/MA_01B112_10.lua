-- このluaスクリプトは、MA_01B112_10.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_02","110051_02_h")
Include("content_adv_advsmall_110051_02","Template110051_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_007)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110051_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_008)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110051_02_011,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_011)
	Camera005 = SetTemplate("Actor005",25.41,CharaPos110051_02_012,"content_motion3d_advarea_common_adv_templatecontroller","Chr_516_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_012)
	Camera006 = SetTemplate("Actor006",10.9,CharaPos110051_02_013,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_013)
	InitializeTemplateRandomCamera110051_02()
	InitializeTemplate110051_02()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110051)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101036","001","101036001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	change_face(Actor002,"Sad")

	--★★パーシヴァル★★:ちょっと待ってよ…<br>意味わかんなくない？
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","MA_01B112_100002")


	--★★ボールス★★:ああ。ノワールとランスロットを<br>護りたいというのに…
	Talk(Actor003,"CHRNAME_BORS","speech","L","MA_01B112_100003")


	--★★ボールス★★:なぜ魔女と結託し<br>ノワールやランスロットと敵対する必要がある？
	Talk(Actor003,"CHRNAME_BORS","speech","L","MA_01B112_100004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ケイ★★:確かに…聖杯を穢してまで<br>継承者を侵蝕しようとした理由もわからぬな
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01B112_100005")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01B112_100006","MA_01B112_100007","MA_01B112_100008")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:侵蝕してまで達成したいことが？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_100010")

	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:恩義ある人の遺児を化け物にして<br>なにをしようって言うのさ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","MA_01B112_100011")

	change_face(Actor003,"Normal")

	--★★ボールス★★:既にペレスがその恩など忘れて、ただ<br>バルバロイの衝動のままに動いている可能性も…
	Talk(Actor003,"CHRNAME_BORS","speech","L","MA_01B112_100012")

	PlayAction(Actor006,"to  Std_Talk")
	change_face(Actor006,"Anger")

	--★★ガラハッド★★:お爺様はノワールやランスロットを招いていた！<br>お爺様はまだお爺様のままだ！！
	Talk(Actor006,"CHRNAME_GALAHAD","speech","L","MA_01B112_100013")

	change_face(Actor004,"Normal")

	--★★ケイ★★:…であれば、余計に不可解だ
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01B112_100014")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Anger")

	--★★ノワール★★:ガラハッドの気持ちを<br>裏切ってまですることなのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_100016")

	PlayAction(Actor006,"to  Std_Talk")
	change_face(Actor006,"Sad")

	--★★ガラハッド★★:が、ガラハッドは…<br>お爺様の判断になにか理由があると信じたい…
	Talk(Actor006,"CHRNAME_GALAHAD","speech","L","MA_01B112_100017")

	change_face(Actor005,"Sad")

	--★★フィエナ★★:フィエナちゃんにもわからないんだ…<br>私たちふたりだけを逃がした理由も
	Talk(Actor005,"CHRNAME_VIENA","speech","L","MA_01B112_100018")

	change_face(Actor005,"Anger")

	--★★フィエナ★★:けどおじい様が<br>ガラハッドを裏切ったなんて考えたくないよ
	Talk(Actor005,"CHRNAME_VIENA","speech","L","MA_01B112_100019")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	change_face(Actor001,"Sad")

	--★★ノワール★★:円卓と銀卓が協力出来ればいいのにな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_100021")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
	change_face(Actor006,"Anger")

	--★★ガラハッド★★:出来るはずなんだ、きっと<br>ノワールがガラハッドを助けてくれたように
	Talk(Actor006,"CHRNAME_GALAHAD","speech","L","MA_01B112_100022")

	PlayAction(Actor006,"to  Std_Sad01")
	change_face(Actor006,"Sad")

	--★★ガラハッド★★:ガラハッドは、その、あのときは<br>あの、嬉しかった
	Talk(Actor006,"CHRNAME_GALAHAD","speech","L","MA_01B112_100023")

	goto Block1end

::Block1end::
	change_face(Actor005,"Sad")

	--★★フィエナ★★:わからなくなっちゃってたんだ<br>おじい様たちの望みがなんなのか
	Talk(Actor005,"CHRNAME_VIENA","speech","L","MA_01B112_100025")


	--★★フィエナ★★:もし本当に『父なる彼の遺児』を守るべく<br>私たちを捨てたのだとしたら、って考えると
	Talk(Actor005,"CHRNAME_VIENA","speech","L","MA_01B112_100026")

	PlayAction(Actor005,"to  Std_Sad01")

	--★★フィエナ★★:その理由もわからないまま<br>ガラハッドに伝えるのはあまりにも──
	Talk(Actor005,"CHRNAME_VIENA","speech","L","MA_01B112_100027")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor006,"Surprise")

	--★★ガラハッド★★:だから姉上は<br>今まで、なにも言ってくれず…？
	Talk(Actor006,"CHRNAME_GALAHAD","speech","L","MA_01B112_100028")

	change_face(Actor001,"Normal")

	--★★ノワール★★:…ガラハッドを悲しませたくなかったんだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_100029")

	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:「銀卓騎士団やお爺様に見放された」…<br>なんてガラハッドには思わせたくないよね
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","MA_01B112_100030")

	change_face(Actor006,"Sad")

	--★★ガラハッド★★:………実際、ガラハッド自身<br>これだけショックを受けているわけだしな
	Talk(Actor006,"CHRNAME_GALAHAD","speech","L","MA_01B112_100032")


	--★★フィエナ★★:ガラハッドを守るべきか、継承者を救うべきか<br>銀卓のみんなにすがるべきか…とかとか
	Talk(Actor005,"CHRNAME_VIENA","speech","L","MA_01B112_100033")


	--★★フィエナ★★:アステラが私たちを逃がした意味も<br>考えなきゃって、頭ぐちゃぐちゃ…だったの
	Talk(Actor005,"CHRNAME_VIENA","speech","L","MA_01B112_100035")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)

	--★★フィエナ★★:だからせめて巫女の務めだけは<br>まっとうしようと思ったんだ、けど
	Talk(Actor005,"CHRNAME_VIENA","speech","L","MA_01B112_100036")

	change_face(Actor004,"Sad")

	--★★ケイ★★:ただ穢した聖杯へ導く<br>餌扱いだったのかもしれぬな
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01B112_100037")


	--★★フィエナ★★:そして結局、ガラハッドを傷つけた………
	Talk(Actor005,"CHRNAME_VIENA","speech","L","MA_01B112_100039")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:帰ろう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_100041")

	change_face(Actor005,"Surprise")

	--★★フィエナ★★:ノワール？
	Talk(Actor005,"CHRNAME_VIENA","speech","L","MA_01B112_100042")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:ペレス王が呼んでいる<br>帰って来いと
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_100043")

	PlayAction(Actor006,"to  Std_Talk")
	change_face(Actor006,"Anger")

	--★★ガラハッド★★:最凶騎士が待ち受けている…！<br>敵の巣窟に飛び込むようなものだ…っ
	Talk(Actor006,"CHRNAME_GALAHAD","speech","L","MA_01B112_100044")


	--★★パーシヴァル★★:ログレスとしては<br>人質を奪還しに行かなきゃならないわけだから
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","MA_01B112_100045")

	change_face(Actor003,"Normal")

	--★★ボールス★★:最優先事項ではあるな
	Talk(Actor003,"CHRNAME_BORS","speech","L","MA_01B112_100046")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ケイ★★:我が王の指示を仰ぎ次第、遠征の準備を…<br>いや、帰郷の支度をしてもらおうか
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01B112_100047")

	change_face(Actor005,"Sad")

	--★★フィエナ★★:だ、だけど…
	Talk(Actor005,"CHRNAME_VIENA","speech","L","MA_01B112_100049")


	--★★ノワール★★:『遺児』を護ってくれるんだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_100050")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
	change_face(Actor006,"Normal")

	--★★ガラハッド★★:──フォー・ラウンド
	Talk(Actor006,"CHRNAME_GALAHAD","speech","L","MA_01B112_100052")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110051)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101036","001","101036001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
