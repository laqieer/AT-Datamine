-- このluaスクリプトは、MA_01107_12.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111014_03","111014_03_h")
Include("content_adv_advsmall_111014_03","Template111014_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111014_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName111014_03,CameraPos111014_03_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111014_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_019_01_StdController","to Std_Loop",CameraAssetBundleName111014_03,CameraPos111014_03_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos111014_03_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleName111014_03,CameraPos111014_03_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos111014_03_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName111014_03,CameraPos111014_03_004)
	Camera005 = SetTemplate("Actor005",nil,CharaPos111014_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName111014_03,CameraPos111014_03_005)
	Camera006 = SetTemplate("Actor006",nil,CharaPos111014_03_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName111014_03,CameraPos111014_03_007)
	InitializeTemplateRandomCamera111014_03()
	InitializeTemplate111014_03()
-- ▼直接出力
force_eyesync(Actor001,"Close")
reserve_eyesync(Actor001,"Close")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111014)
	Actor001 = InitializeCharacter_3D("101051","001","101051001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101052","001","101052001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★ルーシャス★★:断る
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01107_120002")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
	change_face(Actor003,"Sad")

	--★★トリスタン★★:ほらね？
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01107_120004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
reserve_eyesync(Actor001,"Auto")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ルーシャス★★:余が謁見を許したのは麗しのギネヴィアのみだ<br>なぜ他の取り巻きまで通している？
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01107_120005")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ヴェルナルス★★:出迎えはフレンとローラ姉妹が…<br>そこで伝え漏れたものかと
	Talk(Actor002,"CHRNAME_VERNARTH","speech","L","MA_01107_120006")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ルーシャス★★:…ははあ<br>ういやつだな、フレンも
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01107_120007")

	PlayAction(Actor004,"to  Std_Talk")

	--★★ギネヴィア★★:わたしとルーシャス皇太子殿下を<br>ふたりきりで会わせたくなかったのかしらね
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01107_120009")

	change_face(Actor001,"Smile")

	--★★ルーシャス★★:そなたの来訪には深く感謝するよギネヴィア<br>宮殿の奥にてお相手しよう、熱烈にな
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01107_120010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_No")
	change_face(Actor004,"Surprise")

	--★★ギネヴィア★★:待って待って待って違う違う<br>そういうつもりじゃないやめて寒気がする
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01107_120011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ルーシャス★★:クッククク…何故そなたもアーサーも<br>ノワールに入れ込むのか知らぬが
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01107_120012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ルーシャス★★:…継承者、だからかな？
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01107_120013")

	PlayAction(Actor003,"to  Std_Surp")
	change_face(Actor003,"Surprise")

	--★★トリスタン★★:！？
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01107_120014")

	PlayAction(Actor005,"to  Std_Talk")
	change_face(Actor005,"Surprise")

	--★★ガウェイン★★:な、なんでそれ知ってんだ…！？<br>円卓の騎士にしか知らされてないはずなのに…！
	Talk(Actor005,"CHRNAME_GAWAIN","speech","L","MA_01107_120015")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ルーシャス★★:ハハッ！<br>本当にそうだったとは！
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01107_120016")

-- ▼直接出力
SkipDefaultMotion(Actor005)
PlayActionDirect(Actor005,"to  Std_Surp")
-- ▲直接出力

	--★★ガウェイン★★:ウェッッ！？
	Talk(Actor005,"CHRNAME_GAWAIN","speech","L","MA_01107_120017")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ルーシャス★★:将軍将軍！やっぱりだ当たりだ！<br>貴様の言った通りの<ruby=ガウェイン>きゃつ</ruby>がアナだったよ！
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01107_120018")

	PlayAction(Actor005,"to  Std_Sad01")

	--★★ガウェイン★★:ヴェ、ヴェ、ヴェルナルス先生～…！？
	Talk(Actor005,"CHRNAME_GAWAIN","speech","L","MA_01107_120020")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★ヴェルナルス★★:『アナ』とは語弊があります<br>彼は『素直』だと申し上げたのです
	Talk(Actor002,"CHRNAME_VERNARTH","speech","L","MA_01107_120021")

-- ▼直接出力
setup_small_camera_start(RndCamera004)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor005)
PlayActionDirect(Actor005,"to  Std_Sad02")
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★ガウェイン★★:う、う、うそだろ…！？<br>俺、円卓内の秘密をもらしちまった…！？
	Talk(Actor005,"CHRNAME_GAWAIN","speech","L","MA_01107_120022")

-- ▼直接出力
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor003,"to  Std_Worry")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★トリスタン★★:…ギリかな。ルーシャス皇太子殿下が<br>すでに知ってる話の確認…カマカケだろうから
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01107_120023")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
	change_face(Actor004,"Anger")

	--★★ギネヴィア★★:どこで、その情報を手に入れたの…！
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01107_120024")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayActionDirect(Actor003,"to Std_Loop")
PlayActionDirect(Actor005,"to Std_Loop")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ルーシャス★★:情報の価値は稀少性…ゆえにそれこそ秘密だ<br>が、<br>得た情報の真偽は確かめんことにはな？
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01107_120025")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ヴェルナルス★★:ガウェイン、素直なお前が悪いのではない<br>ルーシャス様のお人が悪いだけだ
	Talk(Actor002,"CHRNAME_VERNARTH","speech","L","MA_01107_120026")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ルーシャス★★:では素直な貴様に汚名返上のチャンスをやろう<br>好きな数字はあるかな？
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01107_120028")

	change_face(Actor005,"Smile")

	--★★ガウェイン★★:じゅ、『１０』か『３』かな！！
	Talk(Actor005,"CHRNAME_GAWAIN","speech","L","MA_01107_120029")


	--★★ルーシャス★★:では『３』つ<br>余とゲームをしよう
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01107_120031")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Surp")
-- ▼直接出力
change_face(Actor003,"Surprise")
change_face(Actor004,"Surprise")
change_face(Actor005,"Surprise")
change_face(Actor006,"Surprise")
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor005,"Surprise")

	--★★ガウェイン★★:ええええっ！？！？
	Talk(Actor005,"CHRNAME_GAWAIN","speech","N","MA_01107_120032")

	close_cutin()
-- ▼直接出力
setup_small_camera_start(Camera001)
set_rot(Actor006,{0,-125,0})
keep_ik_lookat(Actor003,Actor005,"J_Head")
keep_ik_lookat(Actor004,Actor005,"J_Head")
keep_ik_lookat(Actor006,Actor005,"J_Head")
-- ▲直接出力

	--★★ルーシャス★★:貴様らが３つすべてクリアできれば<br>兵を出すことを考えてやらんでもないかもしれん
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01107_120034")

-- ▼直接出力
setup_small_camera_start(RndCamera004)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to  Std_Talk")
turn_chara(Actor003,120,0.3)
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★トリスタン★★:なんで『３』なんて言うんだよ！<br>１とか０とかにすればよかったのに！
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01107_120035")

-- ▼直接出力
PlayActionDirect(Actor005,"to  Std_Worry")
turn_chara(Actor005,-105,0.5)
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★ガウェイン★★:いや、でも、俺、<br>うそはつけねーし！！！！
	Talk(Actor005,"CHRNAME_GAWAIN","speech","L","MA_01107_120036")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)

	--★★トリスタン★★:キミって奴はまったく…！
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01107_120037")

-- ▼直接出力
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor001)
set_rot(Actor003,{0,172,0})
set_rot(Actor005,{0,-170,0})
set_rot(Actor006,{0,-160,0})
lookat_weight_reset(Actor003)
lookat_weight_reset(Actor004)
lookat_weight_reset(Actor005)
lookat_weight_reset(Actor006)
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ルーシャス★★:『１０』個<br>ゲームを用意した方が良いかな？
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01107_120038")

	PlayAction(Actor003,"to  Std_No")
	change_face(Actor003,"Normal")

	--★★トリスタン★★:結構です！！<br>３個でオナカいっぱいですからお気遣いなく！
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01107_120039")

	open_select_window_tag(Actor006,"Normal","MA_01107_120041","MA_01107_120042","MA_01107_120043")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
	change_face(Actor006,"Normal")

	--★★ノワール★★:なんでもする<br>力を貸してくれ
	Talk(Actor006,"CHRNAME_NOIR","speech","L","MA_01107_120045")

	change_face(Actor001,"Surprise")

	--★★ルーシャス★★:なんでもする？なんでもする？<br>なんでもする？なんでもするぅ？
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01107_120047")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
force_eyesync(Actor001,"Close")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ルーシャス★★:貴様の言葉は軽いな。覚悟がない<br>せっかくトモダチになれると思っていたが
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01107_120048")

-- ▼直接出力
reserve_eyesync(Actor001,"Auto")
-- ▲直接出力
	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor006,"Normal")

	--★★ノワール★★:ゲームの内容による<br>だけどできることならやるよ
	Talk(Actor006,"CHRNAME_NOIR","speech","L","MA_01107_120050")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Normal")

	--★★ギネヴィア★★:そーよ！判断材料がないわ<br>早くゲームとやらの内容を教えなさい！
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01107_120051")

	change_face(Actor001,"Smile")

	--★★ルーシャス★★:やる気まんまんだな<br>クッククク、嬉しいよ
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01107_120052")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	PlayAction(Actor006,"to  Std_Talk")
	change_face(Actor006,"Normal")

	--★★ノワール★★:もてなしに感謝するよ<br>ルーシャス
	Talk(Actor006,"CHRNAME_NOIR","speech","L","MA_01107_120054")

	PlayAction(Actor003,"to  Std_Worry")
	change_face(Actor003,"Sad")

	--★★トリスタン★★:…なに言ってんの<br>面白がられてるだけじゃん
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01107_120056")

	play_head_motion(Actor006, "No", 0.3, 1.0, false)
	change_face(Actor006,"Normal")

	--★★ノワール★★:俺たちがローマの利益になるか<br>君主は冷静に見極めようとしているだけだ
	Talk(Actor006,"CHRNAME_NOIR","speech","L","MA_01107_120057")

	change_face(Actor001,"Smile")

	--★★ルーシャス★★:クックククク…<br>いいぞ、ノワール、実にいい
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01107_120059")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ルーシャス★★:ゲーム１<br>「余に宝石を献上せよ」
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01107_120061")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Normal")

	--★★トリスタン★★:皇太子殿下はすでに<br>贅を尽くしているでしょう？
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01107_120062")


	--★★ルーシャス★★:ギネヴィアの故郷は<br>世界でも有数の宝石の産地と聞いている
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01107_120063")

	PlayAction(Actor004,"to  Std_Talk")
	change_face(Actor004,"Sad")

	--★★ギネヴィア★★:それはしばらく前の話よ<br>今はもう枯渇してしまって…
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01107_120065")


	--★★ルーシャス★★:鉱山の奥を探せば<br>１つや２つ残っているだろう
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01107_120066")

	PlayAction(Actor004,"to  Std_Sad01")

	--★★ギネヴィア★★:あるかもしれないけれど<br>鉱山はバルバロイの巣窟になっていて…
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01107_120067")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ルーシャス★★:ゆえに貴様らに頼んでいる<br>そのためのＧＳ、そのためのキラーズだろう？
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01107_120069")

	PlayAction(Actor004,"to  Std_Angry")
	change_face(Actor004,"Anger")

	--★★ギネヴィア★★:ゲームとか宝石とか…！<br>あ、あなたの道楽に付き合ってなんか──
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01107_120071")

	open_cutin(1,1)
	on_cutin(1,Actor001,"Smile")

	--★★ルーシャス★★:ゲーム・スタート！！
	Talk(Actor001,"CHRNAME_LUCIUS","speech","N","MA_01107_120073")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(111014)
	InitializeCharacter_3D_Preload("101051","001","101051001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101052","001","101052001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111014_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
