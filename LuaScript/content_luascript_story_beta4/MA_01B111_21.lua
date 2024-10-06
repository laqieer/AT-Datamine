-- このluaスクリプトは、MA_01B111_21.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_01","110071_01_h")
Include("content_adv_advsmall_110071_01","Template110071_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_516_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_002)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110071_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_003)
	InitializeTemplateRandomCamera110071_01()
	InitializeTemplate110071_01()
-- ▼直接出力
load_image("10102021", "content_still_10102021_image", "101020210_StillImage")
set_enable_auto_lookat(Actor, enable)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101028","002","101028002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101036","001","101036001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ガラハッド★★:降参だ
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B111_210002")

-- ▼直接出力
 --PlayPartVoice("フィエナ", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★フィエナ★★:もお負ける気でいるの？<br>戦う前なのに
	Talk(Actor002,"CHRNAME_VIENA","speech","L","MA_01B111_210003")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ガラハッド★★:聖杯は勝ち取るよ姉上<br>バルバロイにだって勝つよ
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B111_210004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "悩む")
-- ▲直接出力

	--★★ガラハッド★★:けれど、継承者と最強騎士…<br>この学園や世界の広さ、全部に参った
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B111_210005")


	--★★ガラハッド★★:こんな大所帯の未来を背負う<br>力や資格に感服する
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B111_210006")

-- ▼直接出力
 --PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ガラハッド★★:ガラハッドだけでなんでもやれると思っていた<br>聖杯発見なんて簡単だ、銀卓騎士も止められると
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B111_210007")

	PlayAction(Actor001,"to  Std_No")

	--★★ガラハッド★★:あの頃の無知な自分が<br>…今は恥ずかしい
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B111_210009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor003,"Normal","MA_01B111_210010","MA_01B111_210011")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ノワール★★:見える範囲しかわからない<br>俺もそうだった、それは普通だよ
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01B111_210013")

-- ▼直接出力
 --PlayPartVoice("ガラハッド", "納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ガラハッド★★:だとすればガラハッド自身の視野が狭かった<br>今もそうだが
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B111_210014")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ランスロット★★:目先しか見えないのは誰もが同じだ<br>学ぶことで少しずつ視野も拡がる
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","MA_01B111_210015")

-- ▼直接出力
 --PlayPartVoice("ガラハッド", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ガラハッド★★:…難しいな<br>学ぶというのは
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B111_210016")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ガラハッド★★:それを教えてくれたのは<br>ノワール、ランスロット、お前たちだが
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B111_210017")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ノワール★★:継承者も最強騎士もまだ道半ばだよ
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01B111_210019")

-- ▼直接出力
 --PlayPartVoice("ガラハッド", "笑い")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ガラハッド★★:ガラハッドはお前たちの<br>絆の強さに打ちのめされてばかりだ
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B111_210020")

	change_face(Actor001,"Sad")

	--★★ガラハッド★★:勝手にふたりきりで<br>聖杯の封印を解いて来たりして──
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B111_210021")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★ランスロット★★:あ、ああー、それはだな
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","MA_01B111_210022")

-- ▼直接出力
 --PlayPartVoice("ガラハッド", "驚き")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ガラハッド★★:ガラハッドなんて要らなかったんだろう<br>結構ショックだったんだからな
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B111_210023")

	goto Block1end

::Block1end::
-- ▼直接出力
 --PlayPartVoice("ランスロット", "悩む")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ランスロット★★:…『ランスロット』を学ぶためだと言ったな<br>この学園に来たのは
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","MA_01B111_210025")


	--★★テロップ★★:「ランスロットこそ最強の騎士<br>目指すべき誉れ高い指針」
	Talk(Actor005,"","narration","N","MA_01B111_210027")


	--★★テロップ★★:いずれはそうなるべきと<br>きっとお爺様はそう祈りを込めたんだ
	Talk(Actor005,"","narration","N","MA_01B111_210028")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ガラハッド★★:ランスロットを追い越せば良いのかとも考えたが<br>もうよくわからないな
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B111_210029")


	--★★ガラハッド★★:もっと学ぶべきことが<br>ほかにもあったようだしな
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B111_210030")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:なら、ノワールに学ぶと良い
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","MA_01B111_210031")

-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ノワール★★:ランスロット…？
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01B111_210033")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "悩む")
-- ▲直接出力

	--★★ランスロット★★:俺の知ることのすべてはノワールに受け継ぐ<br>力も、知も、すべては継承者に
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","MA_01B111_210034")

	PlayAction(Actor004,"to  Std_Talk")
	change_face(Actor004,"Smile")

	--★★ランスロット★★:『ランスロット』を受け継いだノワールを<br>追い越す騎士となれれば、どうだ？
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","MA_01B111_210035")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "悩む")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ガラハッド★★:お爺様に顔向けも出来る…？
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B111_210036")

	open_select_window_tag(Actor003,"Normal","MA_01B111_210037","MA_01B111_210038","MA_01B111_210039")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	elseif is_select(3) then
		goto Block2_3
	end

::Block2_1::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ノワール★★:俺は通過点か？
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01B111_210041")

	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ガラハッド★★:そ、そんなつもりはない…！
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B111_210042")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ランスロット★★:追い抜かれないように走ることだな<br>ノワール？
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","MA_01B111_210043")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ノワール★★:やろう、ガラハッド
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01B111_210045")

-- ▼直接出力
 --PlayPartVoice("ガラハッド", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ガラハッド★★:ノワール？
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B111_210046")

-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ノワール★★:俺はランスロットを追う
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01B111_210047")

-- ▼直接出力
 --PlayPartVoice("ガラハッド", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ガラハッド★★:ガラハッドは、ノワールを追う…？
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B111_210049")

	goto Block2end

::Block2_3::
	CloseTalkWindow()
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ノワール★★:俺もランスロットからすべてを学ぶ
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01B111_210051")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ランスロット★★:もう教えることもないがな
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","MA_01B111_210052")

-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ノワール★★:やっとあんたと並べたんだ<br>しばらくは並走させてくれよ
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01B111_210053")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット", "喜び")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ランスロット★★:………ああ。ついて来てくれ
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","MA_01B111_210054")

	goto Block2end

::Block2end::
	change_face(Actor001,"Normal")

	--★★ガラハッド★★:わかった。ランスロット<br>お前の心意気、受け取った
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B111_210056")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "悩む")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ランスロット★★:己が無知であると自覚しているのなら<br>まだ多くを知れる、広く学べる
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","MA_01B111_210057")

	change_face(Actor004,"Smile")

	--★★ランスロット★★:ゆっくり歩め。ガラハッド
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","MA_01B111_210058")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "怒り")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ガラハッド★★:気遣いは感謝するが<br>ガラハッドはのんびり屋ではない！
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B111_210060")


	--★★ガラハッド★★:ノワール、競争だ
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B111_210061")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ノワール★★:受けて立つよ、ガラハッド
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01B111_210062")

-- ▼直接出力
 --PlayPartVoice("ガラハッド", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ガラハッド★★:モルガン先生に言われたこと<br>少しわかった気がするんだ
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B111_210063")

-- ▼直接出力
 --PlayPartVoice("フィエナ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★フィエナ★★:なんて…言われたの？
	Talk(Actor002,"CHRNAME_VIENA","speech","L","MA_01B111_210064")


	--★★ガラハッド★★:ガラハッドの磨いた銀色が綺麗だと
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B111_210065")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力

	--★★ガラハッド★★:色んなものを映して回れる<br>鏡のようだと
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B111_210066")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0,1.0)
wait_time(1.5)
close_textbox_base()
-- ▲直接出力
-- ▼直接出力
show_image("10102021", 0.0, 0.0, 0.0 ,true,false)
fadein(2.0)
wait_time(1.5)
voiceSignalS = voice_play("VO_MA_01B111_210068")
wait_time(1.0)
	while voiceSignalS.IsProccessing() do
		coroutine.yield()
	end
wait_time(1.5)
fadeout(0,0,0,1.0,2.0)
wait_time(2.5)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("10102021", "content_still_10102021_image", "101020210_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101028","002","101028002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101036","001","101036001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
