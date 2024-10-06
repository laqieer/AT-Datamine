-- このluaスクリプトは、MA_01B900_29.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_04","110011_04_h")
Include("content_adv_advsmall_110011_04","Template110011_04_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_04_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_04_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_SitController","to Sit02_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_002)
	InitializeTemplateRandomCamera110011_04()
	InitializeTemplate110011_04()
-- ▼直接出力
se_play("SE_ADV_MA_01C109_01_Bell")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115014)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor002")
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	change_face(Actor002,"Sad")

	--★★ガラハッド★★:………不潔だな、僕は
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B900_290002")


	--★★ガラハッド★★:自分の歩む道くらい<br>自分で決めるべきだと思う
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B900_290003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ガラハッド★★:その高潔さだけが騎士としての価値だと<br>信じて疑わなかったんだ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B900_290004")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01B900_290005","MA_01B900_290006","MA_01B900_290007")
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

	--★★ノワール★★:そうして生きて行く道もあるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_290009")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:ああ、そうだな<br>強くてたくましい生き方だ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B900_290010")

	change_face(Actor002,"Sad")

	--★★ガラハッド★★:ガラハッドもそうであろうと思った<br>誰に頼ることもない無敵な騎士像に憧れてたんだ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B900_290011")

	change_face(Actor002,"Sad")

	--★★ガラハッド★★:あの日出会ったときのアステラのように<br>僕と暮らしてくれた銀卓騎士やお爺様のように
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B900_290012")

	change_face(Actor002,"Normal")

	--★★ガラハッド★★:だけど──
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B900_290013")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:誰かに寄りかからないと<br>生きていけないこともあるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_290015")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:そうだな、きっとそうなんだ<br>学園では皆寄り添って生きてる
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B900_290016")

	change_face(Actor002,"Normal")

	--★★ガラハッド★★:だからこそ人が集まり、支え合い<br>平和を願う強い心が培われるんだろう
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B900_290018")

	change_face(Actor001,"Normal")

	--★★ノワール★★:…聖杯城の人たちも助け合って生きてただろ？<br>バルバロイになってもなお、護り合って
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_290019")

	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:………！<br>うん…、うん…！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B900_290021")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:自分で決めるべきだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_290023")

	change_face(Actor002,"Sad")

	--★★ガラハッド★★:…強いんだな、ノワールは
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B900_290025")

	change_face(Actor002,"Sad")

	--★★ガラハッド★★:ガラハッドは…<br>そうなるにはまだ、足らないんだ…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B900_290026")

	goto Block1end

::Block1end::
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:混じり、ともに流れゆくことが<br>お前たちの強さと見たんだ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B900_290028")

	change_face(Actor002,"Anger")

	--★★ガラハッド★★:どれだけ汚れても足掻く意志を見た<br>己よりも大切な者を護ろうとする覚悟を見た
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B900_290029")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ガラハッド★★:心がすり減ろうと<br>ときに曇ってしまおうと
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B900_290030")


	--★★ガラハッド★★:姉上は我が道を往く覚悟を決められた<br>状況に強いられた結果だとしても、立派だ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B900_290032")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ガラハッド★★:僕も踏み出さなければならない
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B900_290033")

	change_face(Actor001,"Sad")

	--★★ノワール★★:誰かの命を引き換えにしないと<br>手に入らない平和なんて狂ってる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_290034")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:だから<br>終わらせよう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_290036")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:ガラハッドにも分けてくれ<br>その重荷を
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B900_290037")


	--★★ガラハッド★★:…僕が姉上を見送る
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B900_290038")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ガラハッド★★:我が銀色こそ<br>お前の黄金を映す鏡面
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B900_290040")


	--★★ガラハッド★★:継承者が繰り返して来た決断の業──<br>荒れた騎士道を歩み続けるその強さ──
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B900_290041")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ガラハッド★★:──選択の勇気を分けてくれ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B900_290042")

	change_face(Actor002,"Anger")

	--★★ガラハッド★★:いくら傷ついても歩み続ける強さを
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B900_290044")

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
MobsNo = 0
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
